namespace LootCreator
{
    partial class F_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            btn_convert = new Button();
            panel1 = new Panel();
            pn_list = new Panel();
            btn_add = new Button();
            label5 = new Label();
            label4 = new Label();
            btn_remove = new Button();
            btn_close = new Button();
            tb_id = new TextBox();
            tb_name = new TextBox();
            button1 = new Button();
            tb_out = new TextBox();
            tb_in = new TextBox();
            label3 = new Label();
            cb_list = new ComboBox();
            btn_back = new Button();
            tb_chance = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_fandom = new Button();
            panel1.SuspendLayout();
            pn_list.SuspendLayout();
            SuspendLayout();
            // 
            // btn_convert
            // 
            btn_convert.BackColor = Color.Gray;
            btn_convert.Cursor = Cursors.Hand;
            btn_convert.FlatStyle = FlatStyle.Flat;
            btn_convert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_convert.ForeColor = Color.White;
            btn_convert.Location = new Point(550, 269);
            btn_convert.Name = "btn_convert";
            btn_convert.Size = new Size(90, 24);
            btn_convert.TabIndex = 0;
            btn_convert.Text = "CONVERT";
            btn_convert.UseVisualStyleBackColor = false;
            btn_convert.Click += btn_convert_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pn_list);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tb_out);
            panel1.Controls.Add(tb_in);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cb_list);
            panel1.Location = new Point(12, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 229);
            panel1.TabIndex = 1;
            // 
            // pn_list
            // 
            pn_list.BackColor = Color.Silver;
            pn_list.BorderStyle = BorderStyle.Fixed3D;
            pn_list.Controls.Add(btn_add);
            pn_list.Controls.Add(label5);
            pn_list.Controls.Add(label4);
            pn_list.Controls.Add(btn_remove);
            pn_list.Controls.Add(btn_close);
            pn_list.Controls.Add(tb_id);
            pn_list.Controls.Add(tb_name);
            pn_list.Location = new Point(221, 40);
            pn_list.Name = "pn_list";
            pn_list.Size = new Size(243, 141);
            pn_list.TabIndex = 8;
            pn_list.Visible = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Gray;
            btn_add.Cursor = Cursors.Hand;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(145, 61);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(81, 24);
            btn_add.TabIndex = 12;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(11, 11);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 11;
            label5.Text = "ITEM NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(11, 64);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 9;
            label4.Text = "ID";
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.Gray;
            btn_remove.Cursor = Cursors.Hand;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_remove.ForeColor = Color.White;
            btn_remove.Location = new Point(11, 103);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(81, 24);
            btn_remove.TabIndex = 10;
            btn_remove.Text = "REMOVE";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Gray;
            btn_close.Cursor = Cursors.Hand;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(145, 103);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(81, 24);
            btn_close.TabIndex = 9;
            btn_close.Text = "CLOSE";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // tb_id
            // 
            tb_id.BackColor = Color.Gainsboro;
            tb_id.Cursor = Cursors.IBeam;
            tb_id.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tb_id.Location = new Point(36, 61);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(81, 24);
            tb_id.TabIndex = 5;
            tb_id.Text = "0";
            tb_id.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_name
            // 
            tb_name.BackColor = Color.Gainsboro;
            tb_name.Cursor = Cursors.IBeam;
            tb_name.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tb_name.Location = new Point(11, 29);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(215, 24);
            tb_name.TabIndex = 4;
            tb_name.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(493, 11);
            button1.Name = "button1";
            button1.Size = new Size(81, 23);
            button1.TabIndex = 13;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += cb_list_Click;
            // 
            // tb_out
            // 
            tb_out.BackColor = Color.Gainsboro;
            tb_out.Cursor = Cursors.IBeam;
            tb_out.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tb_out.ForeColor = Color.DarkGreen;
            tb_out.Location = new Point(13, 40);
            tb_out.Multiline = true;
            tb_out.Name = "tb_out";
            tb_out.ReadOnly = true;
            tb_out.ScrollBars = ScrollBars.Vertical;
            tb_out.Size = new Size(595, 173);
            tb_out.TabIndex = 1;
            tb_out.Visible = false;
            // 
            // tb_in
            // 
            tb_in.BackColor = Color.Gainsboro;
            tb_in.Cursor = Cursors.IBeam;
            tb_in.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tb_in.ForeColor = Color.Black;
            tb_in.Location = new Point(13, 40);
            tb_in.Multiline = true;
            tb_in.Name = "tb_in";
            tb_in.ScrollBars = ScrollBars.Vertical;
            tb_in.Size = new Size(595, 173);
            tb_in.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(38, 14);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 7;
            label3.Text = "List item name convert to id";
            // 
            // cb_list
            // 
            cb_list.FormattingEnabled = true;
            cb_list.ImeMode = ImeMode.Off;
            cb_list.Location = new Point(200, 11);
            cb_list.Name = "cb_list";
            cb_list.Size = new Size(287, 23);
            cb_list.TabIndex = 6;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Gray;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(12, 269);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(90, 24);
            btn_back.TabIndex = 2;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // tb_chance
            // 
            tb_chance.BackColor = Color.Gainsboro;
            tb_chance.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tb_chance.Location = new Point(335, 269);
            tb_chance.Name = "tb_chance";
            tb_chance.Size = new Size(81, 24);
            tb_chance.TabIndex = 3;
            tb_chance.Text = "10000";
            tb_chance.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(193, 274);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 4;
            label1.Text = "CHANCE RANDOM 50%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(95, 9);
            label2.Name = "label2";
            label2.Size = new Size(400, 15);
            label2.TabIndex = 5;
            label2.Text = "Copy loot from tibiawiki.com.br or click button search from TibiaFandom";
            // 
            // btn_fandom
            // 
            btn_fandom.BackColor = Color.Gray;
            btn_fandom.Cursor = Cursors.Hand;
            btn_fandom.FlatStyle = FlatStyle.Flat;
            btn_fandom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fandom.ForeColor = Color.White;
            btn_fandom.Location = new Point(501, 5);
            btn_fandom.Name = "btn_fandom";
            btn_fandom.Size = new Size(139, 23);
            btn_fandom.TabIndex = 14;
            btn_fandom.Text = "TibiaFandom Convert";
            btn_fandom.UseVisualStyleBackColor = false;
            btn_fandom.Click += btn_fandom_Click;
            // 
            // F_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(652, 301);
            Controls.Add(btn_fandom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_chance);
            Controls.Add(btn_back);
            Controls.Add(panel1);
            Controls.Add(btn_convert);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "F_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loot Creator by RobertoCarlosPMG";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pn_list.ResumeLayout(false);
            pn_list.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_convert;
        private Panel panel1;
        private TextBox tb_out;
        private Button btn_back;
        private TextBox tb_chance;
        private Label label1;
        private Label label2;
        private ComboBox cb_list;
        private Label label3;
        private Panel pn_list;
        private Label label5;
        private Label label4;
        private Button btn_remove;
        private Button btn_close;
        private TextBox tb_id;
        private TextBox tb_name;
        private Button btn_add;
        private Button button1;
        public TextBox tb_in;
        private Button btn_fandom;
    }
}