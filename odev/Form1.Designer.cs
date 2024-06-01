namespace odev
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            txtSifre = new TextBox();
            txtKullaniciGirisi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnGirisYap = new Button();
            btnLogout = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(btnLogout);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(txtKullaniciGirisi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGirisYap);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(286, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Screen";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(111, 57);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 4;
            // 
            // txtKullaniciGirisi
            // 
            txtKullaniciGirisi.Location = new Point(111, 22);
            txtKullaniciGirisi.Name = "txtKullaniciGirisi";
            txtKullaniciGirisi.Size = new Size(100, 23);
            txtKullaniciGirisi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 60);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Şifre : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Girişi :";
            // 
            // btnGirisYap
            // 
            btnGirisYap.ForeColor = SystemColors.ActiveCaptionText;
            btnGirisYap.Location = new Point(50, 86);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(75, 23);
            btnGirisYap.TabIndex = 0;
            btnGirisYap.Text = "Login";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnLogout
            // 
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(136, 86);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSifre;
        private TextBox txtKullaniciGirisi;
        private Label label2;
        private Label label1;
        private Button btnGirisYap;
        private Button btnLogout;
    }
}
