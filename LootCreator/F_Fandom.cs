using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LootCreator
{
    public partial class F_Fandom : Form
    {
        F_Main f_main;
        string Recep;

        public F_Fandom(F_Main f)
        {
            InitializeComponent();
            f_main = f;
        }
        private async Task btn_convert_ClickAsync(object sender, EventArgs e)
        {
            string f = tb_monster.Text.Replace(" ", "_");
            
            await HttpOps($"https://tibia.fandom.com/wiki/Loot_Statistics:{f}");
            string padrao = @"<td class=""loot_list_no_border"">(\d+(?:-\d+)?|(?:-)?|\d+)</td>\s*<td><a[^>]*>([^<]*)</a></td>";

            MatchCollection matches = Regex.Matches(Recep, padrao);
            string infoFormat = string.Empty;
            HashSet<string> unique = new HashSet<string>();

            foreach (Match match in matches)
            {
                string qtd = match.Groups[1].Value;
                string listName = match.Groups[2].Value;
                if (string.IsNullOrWhiteSpace(qtd) || qtd == "-")
                {
                    qtd = "0-1";
                }
                if (!qtd.Contains("-"))
                {
                    qtd = "0-" + qtd;
                }

                if (!unique.Contains(listName))
                {
                    infoFormat += $"{qtd} {listName}, ";
                    unique.Add(listName);
                }
            }

            if (!string.IsNullOrEmpty(infoFormat))
            {
                infoFormat = infoFormat.TrimEnd(',', ' ');
                f_main.tb_in.Text = infoFormat;
                f_main.lb_target.Visible = true;
                f_main.lb_target.Text = $"Loot from: {f.Replace("_", " ")}";
            }
            else
            {
                MessageBox.Show("Information empty", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }
        private async Task HttpOps(string url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        Recep = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        MessageBox.Show("Search not found!", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connect link: " + ex.Message, "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_convert_Click(object sender, EventArgs e)
        {
            btn_convert_ClickAsync(sender, e);
        }
    }
}