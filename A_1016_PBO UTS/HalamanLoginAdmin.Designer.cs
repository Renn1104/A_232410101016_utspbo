namespace A_1016_PBO_UTS
{
    partial class HalamanLoginAdmin
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(847, 300);
            label1.Name = "label1";
            label1.Size = new Size(226, 79);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(803, 449);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(803, 538);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 39);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1256, 614);
            button1.Name = "button1";
            button1.Size = new Size(206, 77);
            button1.TabIndex = 3;
            button1.Text = "Masuk";
            button1.UseVisualStyleBackColor = false;
            // 
            // HalamanLoginAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.halamanlogin_1;
            ClientSize = new Size(1894, 1009);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "HalamanLoginAdmin";
            Text = "HalamanLoginAdmin";
            Load += HalamanLoginAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}