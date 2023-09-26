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
            pn_main = new Panel();
            lb_target = new Label();
            nud_unique = new NumericUpDown();
            button1 = new Button();
            btn_fandom = new Button();
            nud_chance = new NumericUpDown();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            tb_out = new TextBox();
            cb_list = new ComboBox();
            tb_in = new TextBox();
            nud_percent = new NumericUpDown();
            btn_back = new Button();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            pn_list = new Panel();
            btn_add = new Button();
            label5 = new Label();
            label4 = new Label();
            btn_remove = new Button();
            btn_close = new Button();
            tb_id = new TextBox();
            tb_name = new TextBox();
            pn_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_unique).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_chance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_percent).BeginInit();
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
            btn_convert.Location = new Point(567, 349);
            btn_convert.Name = "btn_convert";
            btn_convert.Size = new Size(73, 24);
            btn_convert.TabIndex = 0;
            btn_convert.Text = "CONVERT";
            btn_convert.UseVisualStyleBackColor = false;
            btn_convert.Click += btn_convert_Click;
            // 
            // pn_main
            // 
            pn_main.BackColor = Color.Silver;
            pn_main.BorderStyle = BorderStyle.Fixed3D;
            pn_main.Controls.Add(lb_target);
            pn_main.Controls.Add(button1);
            pn_main.Controls.Add(label6);
            pn_main.Controls.Add(label3);
            pn_main.Controls.Add(tb_out);
            pn_main.Controls.Add(cb_list);
            pn_main.Controls.Add(tb_in);
            pn_main.Location = new Point(12, 41);
            pn_main.Name = "pn_main";
            pn_main.Size = new Size(628, 305);
            pn_main.TabIndex = 1;
            // 
            // lb_target
            // 
            lb_target.BackColor = Color.Transparent;
            lb_target.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_target.ForeColor = Color.Black;
            lb_target.Location = new Point(16, 13);
            lb_target.Name = "lb_target";
            lb_target.Size = new Size(210, 24);
            lb_target.TabIndex = 15;
            lb_target.Text = "-";
            lb_target.TextAlign = ContentAlignment.MiddleLeft;
            lb_target.Visible = false;
            // 
            // nud_unique
            // 
            nud_unique.BackColor = Color.Gainsboro;
            nud_unique.Cursor = Cursors.IBeam;
            nud_unique.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nud_unique.Location = new Point(458, 352);
            nud_unique.Name = "nud_unique";
            nud_unique.Size = new Size(49, 21);
            nud_unique.TabIndex = 19;
            nud_unique.TextAlign = HorizontalAlignment.Center;
            nud_unique.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(558, 13);
            button1.Name = "button1";
            button1.Size = new Size(53, 23);
            button1.TabIndex = 13;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += cb_list_Click;
            // 
            // btn_fandom
            // 
            btn_fandom.BackColor = Color.Gray;
            btn_fandom.Cursor = Cursors.Hand;
            btn_fandom.FlatStyle = FlatStyle.Flat;
            btn_fandom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fandom.ForeColor = Color.White;
            btn_fandom.Location = new Point(501, 9);
            btn_fandom.Name = "btn_fandom";
            btn_fandom.Size = new Size(139, 23);
            btn_fandom.TabIndex = 14;
            btn_fandom.Text = "TibiaFandom Convert";
            btn_fandom.UseVisualStyleBackColor = false;
            btn_fandom.Click += btn_fandom_Click;
            // 
            // nud_chance
            // 
            nud_chance.BackColor = Color.Gainsboro;
            nud_chance.Cursor = Cursors.IBeam;
            nud_chance.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nud_chance.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nud_chance.Location = new Point(315, 352);
            nud_chance.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_chance.Name = "nud_chance";
            nud_chance.Size = new Size(76, 21);
            nud_chance.TabIndex = 18;
            nud_chance.TextAlign = HorizontalAlignment.Center;
            nud_chance.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(400, 15);
            label2.TabIndex = 5;
            label2.Text = "Copy loot from tibiawiki.com.br or click button search from TibiaFandom";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(90, 281);
            label6.Name = "label6";
            label6.Size = new Size(434, 15);
            label6.TabIndex = 14;
            label6.Text = "Make (a) fixed chance 100%, (u) item unique = true. Ex: 0-1 ferumbras' hat(a)(u)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(231, 17);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 7;
            label3.Text = "List name to id:";
            // 
            // tb_out
            // 
            tb_out.BackColor = Color.Gainsboro;
            tb_out.Cursor = Cursors.IBeam;
            tb_out.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tb_out.ForeColor = Color.DarkGreen;
            tb_out.Location = new Point(15, 45);
            tb_out.Multiline = true;
            tb_out.Name = "tb_out";
            tb_out.ReadOnly = true;
            tb_out.ScrollBars = ScrollBars.Vertical;
            tb_out.Size = new Size(595, 233);
            tb_out.TabIndex = 1;
            tb_out.Visible = false;
            // 
            // cb_list
            // 
            cb_list.BackColor = Color.Gainsboro;
            cb_list.FormattingEnabled = true;
            cb_list.ImeMode = ImeMode.Off;
            cb_list.Location = new Point(326, 13);
            cb_list.Name = "cb_list";
            cb_list.Size = new Size(224, 23);
            cb_list.TabIndex = 6;
            // 
            // tb_in
            // 
            tb_in.BackColor = Color.Gainsboro;
            tb_in.Cursor = Cursors.IBeam;
            tb_in.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tb_in.ForeColor = Color.Black;
            tb_in.Location = new Point(16, 45);
            tb_in.Multiline = true;
            tb_in.Name = "tb_in";
            tb_in.ScrollBars = ScrollBars.Vertical;
            tb_in.Size = new Size(595, 233);
            tb_in.TabIndex = 0;
            // 
            // nud_percent
            // 
            nud_percent.BackColor = Color.Gainsboro;
            nud_percent.Cursor = Cursors.IBeam;
            nud_percent.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nud_percent.Location = new Point(209, 352);
            nud_percent.Name = "nud_percent";
            nud_percent.Size = new Size(53, 21);
            nud_percent.TabIndex = 16;
            nud_percent.TextAlign = HorizontalAlignment.Center;
            nud_percent.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Gray;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(12, 349);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(64, 24);
            btn_back.TabIndex = 2;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(127, 354);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "Randomize: %";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(268, 354);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 17;
            label7.Text = "Chance:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(400, 354);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 20;
            label8.Text = "Unique: %";
            // 
            // pn_list
            // 
            pn_list.BackColor = Color.Silver;
            pn_list.BorderStyle = BorderStyle.FixedSingle;
            pn_list.Controls.Add(btn_add);
            pn_list.Controls.Add(label5);
            pn_list.Controls.Add(label4);
            pn_list.Controls.Add(btn_remove);
            pn_list.Controls.Add(btn_close);
            pn_list.Controls.Add(tb_id);
            pn_list.Controls.Add(tb_name);
            pn_list.Location = new Point(329, 82);
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
            // F_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(652, 382);
            Controls.Add(pn_list);
            Controls.Add(nud_unique);
            Controls.Add(pn_main);
            Controls.Add(label2);
            Controls.Add(nud_chance);
            Controls.Add(btn_fandom);
            Controls.Add(btn_back);
            Controls.Add(btn_convert);
            Controls.Add(nud_percent);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "F_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loot Creator by RobertoCarlosPMG";
            pn_main.ResumeLayout(false);
            pn_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_unique).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_chance).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_percent).EndInit();
            pn_list.ResumeLayout(false);
            pn_list.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_convert;
        private Panel pn_main;
        private TextBox tb_out;
        private Button btn_back;
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
        private Label label6;
        public Label lb_target;
        private NumericUpDown nud_percent;
        private Label label7;
        private NumericUpDown nud_chance;
        private NumericUpDown nud_unique;
        private Label label8;
    }
}