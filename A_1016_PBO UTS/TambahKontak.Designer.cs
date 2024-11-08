namespace A_1016_PBO_UTS
{
    partial class TambahKontak
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
            label25 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(765, 303);
            label25.Name = "label25";
            label25.Size = new Size(376, 53);
            label25.TabIndex = 159;
            label25.Text = "Tambah Kontak";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(592, 421);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(720, 39);
            textBox1.TabIndex = 160;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(592, 520);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(720, 39);
            textBox2.TabIndex = 161;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(592, 612);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(720, 39);
            textBox3.TabIndex = 162;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(857, 689);
            button1.Name = "button1";
            button1.Size = new Size(185, 75);
            button1.TabIndex = 163;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(492, 421);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 164;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(498, 527);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 165;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(492, 615);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 166;
            label3.Text = "NoHP";
            // 
            // TambahKontak
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.halamandashbordadmin_11;
            ClientSize = new Size(1894, 1009);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label25);
            Name = "TambahKontak";
            Text = "TambahKontak";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label25;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}