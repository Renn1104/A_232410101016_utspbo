namespace A_1016_PBO_UTS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1159, 379);
            label1.Name = "label1";
            label1.Size = new Size(303, 53);
            label1.TabIndex = 0;
            label1.Text = "CONTACT APP\r\n";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1220, 462);
            button1.Name = "button1";
            button1.Size = new Size(196, 46);
            button1.TabIndex = 6;
            button1.Text = "HalamanKontak";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1220, 542);
            button2.Name = "button2";
            button2.Size = new Size(196, 46);
            button2.TabIndex = 7;
            button2.Text = "HalamanLogin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click; // Tambahkan event handler di sini
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1894, 1009);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanLoginAdmin loginForm = new HalamanLoginAdmin();
            loginForm.Show();
        }

        private Label label1;
        private Button button1;
        private Button button2;
    }
}
