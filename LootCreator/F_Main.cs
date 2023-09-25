using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace LootCreator
{
    public partial class F_Main : Form
    {
        public string endl = Environment.NewLine;
        string Arquivo = "nameid.list";

        List<KeyValuePair<string, int>> listID = new List<KeyValuePair<string, int>>();
        public F_Main()
        {
            InitializeComponent();
            LoadList();
        }
        private void btn_convert_Click(object sender, EventArgs e)
        {
            string texto = tb_in.Text;

            string[] itens = texto.Split(new string[] { ", " }, StringSplitOptions.None);

            List<Item> listaDeItens = new List<Item>();

            foreach (string item in itens)
            {
                Match match = Regex.Match(item, @"(\d+)-(\d+) (.+)");
                if (match.Success)
                {
                    int countMin = int.Parse(match.Groups[1].Value);
                    int countMax = int.Parse(match.Groups[2].Value);
                    string itemName = match.Groups[3].Value;

                    Item itemObj = new Item(countMin, countMax, itemName);
                    listaDeItens.Add(itemObj);
                }
                else
                {
                    string itemName = item;
                    Item itemObj = new Item(0, 1, itemName);
                    listaDeItens.Add(itemObj);
                }
            }

            tb_out.Text = "monster.loot = {" + endl;
            foreach (Item item in listaDeItens)
            {
                int chance;
                string u = "";

                if (item.CountMax < 2 && !item.ItemName.Contains("(sempre)") && !item.ItemName.Contains("(a)"))
                {
                    chance = Convert.ToInt32(getChance(item.ItemName)) / 4;
                }
                else
                {
                    chance = Convert.ToInt32(getChance(item.ItemName));
                }

                if (item.ItemName.Contains("(u)"))
                {
                    u = ", unique = true";
                }
                item.ItemName = setFilter(item.ItemName);

                int matchingID = -1;

                foreach (var kp in listID)
                {
                    if (kp.Key == item.ItemName)
                    {
                        matchingID = kp.Value;
                        break;
                    }
                }

                if (matchingID != -1)
                {
                    tb_out.Text += $"\t{{ id = {matchingID}, chance = {chance}, maxCount = {item.CountMax}{u} }}, -- {item.ItemName}" + Environment.NewLine;
                }
                else
                {
                    tb_out.Text += $"\t{{ name = \"{item.ItemName}\", chance = {chance}, maxCount = {item.CountMax}{u} }}," + Environment.NewLine;
                }

            }
            tb_out.Text += "}";
            tb_out.Visible = true;
            tb_in.Visible = false;
        }
        private string getChance(string item)
        {
            if (item.Contains("(sempre)") || item.Contains("(a)"))
            {
                return "100000";
            }
            else
            {
                int tbchance = Convert.ToInt32(tb_chance.Text);
                Random random = new Random();
                int variation = random.Next(tbchance - (tbchance / 2), tbchance + (tbchance / 2) + 1);
                return variation.ToString();
            }
        }
        private string setFilter(string item)
        {
            item = item.ToLower().Replace("(sempre)", "").Replace("(a)", "").Trim();

            if (item.EndsWith("ies"))
            {
                item = item.Replace("ies", "y").Trim();
            }
            if (item.EndsWith("es"))
            {
                item = item.Replace("es", "").TrimEnd();
            }
            if (item.EndsWith("s") && !item.Contains("legs") && !item.Contains("boots") && !item.Contains("remains"))
            {
                item = item.TrimEnd('s');
            }
            if (item.EndsWith("(u)"))
            {
                item = item.Replace("(u)", "").TrimEnd();
            }
            return item;
        }

        private void LoadList()
        {
            listID.Clear();
            cb_list.Items.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(Arquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] partes = linha.Split('=');

                        if (partes.Length == 2)
                        {
                            string namelist = partes[0].Trim();
                            int qtd;

                            if (int.TryParse(partes[1].Trim(), out qtd))
                            {
                                listID.Add(new KeyValuePair<string, int>(namelist, qtd));
                            }
                        }
                    }
                }

                foreach (var par in listID)
                {
                    cb_list.Items.Add($"{par.Key} = {par.Value}");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error to load archive: {e.Message}", "ERROR LOAD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            tb_in.Visible = true;
            tb_out.Visible = false;
            tb_out.Clear();
        }
        private void btn_fandom_Click(object sender, EventArgs e)
        {
            F_Fandom f_Fandom = new(this);
            f_Fandom.ShowDialog();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            pn_list.Visible = false;
            pn_main.Enabled = true;
            cb_list.ResetText();
        }
        private void cb_list_Click(object sender, EventArgs e)
        {
            pn_list.Visible = true;
            pn_main.Enabled = false;

            string txtopc = cb_list.Text;
            int idx = txtopc.IndexOf('=');
            if (cb_list.Text != string.Empty)
            {
                if (idx >= 0)
                {
                    tb_id.Text = txtopc.Substring(idx + 2);
                    tb_name.Text = txtopc.Substring(0, idx - 1);
                }
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string id = tb_id.Text;

            try
            {
                using (StreamWriter sw = new StreamWriter(Arquivo, true))
                {
                    sw.WriteLine($"{name} = {id}");
                }
            }
            catch { }
            cb_list.Text = $"{name} = {id}";
            tb_name.Clear();
            tb_id.Clear();
            LoadList();
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string id = tb_id.Text;

            try
            {
                List<KeyValuePair<string, int>> listID = new List<KeyValuePair<string, int>>();
                using (StreamReader sr = new StreamReader(Arquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] partes = linha.Split('=');

                        if (partes.Length == 2)
                        {
                            string namelist = partes[0].Trim();
                            int qtd;

                            if (int.TryParse(partes[1].Trim(), out qtd))
                            {
                                if (namelist != name && qtd != int.Parse(id))
                                {
                                    listID.Add(new KeyValuePair<string, int>(namelist, qtd));
                                }
                            }
                        }
                    }
                }

                using (StreamWriter sw = new StreamWriter(Arquivo))
                {
                    foreach (var par in listID)
                    {
                        sw.WriteLine($"{par.Key} = {par.Value}");
                    }
                }
            }
            catch { }
            cb_list.ResetText();
            LoadList();
        }
    }
}
class Item
{
    public int CountMin { get; set; }
    public int CountMax { get; set; }
    public string ItemName { get; set; }

    public Item(int countMin, int countMax, string itemName)
    {
        CountMin = countMin;
        CountMax = countMax;
        ItemName = itemName;
    }
}