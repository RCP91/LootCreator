namespace LootCreator
{
    partial class F_Fandom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Fandom));
            tb_monster = new TextBox();
            btn_convert = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // tb_monster
            // 
            tb_monster.BackColor = Color.Gainsboro;
            tb_monster.Cursor = Cursors.IBeam;
            tb_monster.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tb_monster.ForeColor = Color.Black;
            tb_monster.Location = new Point(12, 27);
            tb_monster.Multiline = true;
            tb_monster.Name = "tb_monster";
            tb_monster.Size = new Size(338, 28);
            tb_monster.TabIndex = 0;
            // 
            // btn_convert
            // 
            btn_convert.BackColor = Color.Gray;
            btn_convert.Cursor = Cursors.Hand;
            btn_convert.FlatStyle = FlatStyle.Flat;
            btn_convert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_convert.ForeColor = Color.White;
            btn_convert.Location = new Point(357, 27);
            btn_convert.Name = "btn_convert";
            btn_convert.Size = new Size(90, 28);
            btn_convert.TabIndex = 1;
            btn_convert.Text = "SEARCH";
            btn_convert.UseVisualStyleBackColor = false;
            btn_convert.Click += btn_convert_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(147, 9);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 6;
            label2.Text = "Monster Name";
            // 
            // F_Fandom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(459, 67);
            Controls.Add(label2);
            Controls.Add(btn_convert);
            Controls.Add(tb_monster);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "F_Fandom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convert Tibia.Fandom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tb_monster;
        private Button btn_convert;
        private Label label2;
    }
}