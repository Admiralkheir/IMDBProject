namespace IMDBProject.WinUI.UserForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.btnLoginGiris = new System.Windows.Forms.Button();
            this.linkKayitOl = new System.Windows.Forms.LinkLabel();
            this.linkSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(58, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciSifre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKullaniciSifre.Location = new System.Drawing.Point(116, 132);
            this.txtKullaniciSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.PasswordChar = '*';
            this.txtKullaniciSifre.Size = new System.Drawing.Size(205, 26);
            this.txtKullaniciSifre.TabIndex = 8;
            // 
            // btnLoginGiris
            // 
            this.btnLoginGiris.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLoginGiris.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnLoginGiris.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoginGiris.ForeColor = System.Drawing.Color.Maroon;
            this.btnLoginGiris.Location = new System.Drawing.Point(134, 188);
            this.btnLoginGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoginGiris.Name = "btnLoginGiris";
            this.btnLoginGiris.Size = new System.Drawing.Size(157, 39);
            this.btnLoginGiris.TabIndex = 10;
            this.btnLoginGiris.Text = "Giriş";
            this.btnLoginGiris.UseVisualStyleBackColor = false;
            this.btnLoginGiris.Click += new System.EventHandler(this.btnLoginGiris_Click);
            // 
            // linkKayitOl
            // 
            this.linkKayitOl.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkKayitOl.AutoSize = true;
            this.linkKayitOl.BackColor = System.Drawing.Color.Maroon;
            this.linkKayitOl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkKayitOl.ForeColor = System.Drawing.Color.Transparent;
            this.linkKayitOl.LinkColor = System.Drawing.Color.White;
            this.linkKayitOl.Location = new System.Drawing.Point(242, 257);
            this.linkKayitOl.Name = "linkKayitOl";
            this.linkKayitOl.Size = new System.Drawing.Size(91, 19);
            this.linkKayitOl.TabIndex = 11;
            this.linkKayitOl.TabStop = true;
            this.linkKayitOl.Text = "Şimdi kayıt ol";
            this.linkKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKayitOl_LinkClicked);
            // 
            // linkSifremiUnuttum
            // 
            this.linkSifremiUnuttum.AutoSize = true;
            this.linkSifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.linkSifremiUnuttum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkSifremiUnuttum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkSifremiUnuttum.LinkColor = System.Drawing.Color.CadetBlue;
            this.linkSifremiUnuttum.Location = new System.Drawing.Point(223, 112);
            this.linkSifremiUnuttum.Name = "linkSifremiUnuttum";
            this.linkSifremiUnuttum.Size = new System.Drawing.Size(93, 15);
            this.linkSifremiUnuttum.TabIndex = 12;
            this.linkSifremiUnuttum.TabStop = true;
            this.linkSifremiUnuttum.Text = "Şifremi Unuttum";
            this.linkSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSifremiUnuttum_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(78, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bize katılmak ister misin ? ";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(116, 69);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(205, 26);
            this.txtKullaniciAdi.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 363);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.linkSifremiUnuttum);
            this.Controls.Add(this.linkKayitOl);
            this.Controls.Add(this.btnLoginGiris);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.Button btnLoginGiris;
        private System.Windows.Forms.LinkLabel linkKayitOl;
        private System.Windows.Forms.LinkLabel linkSifremiUnuttum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
    }
}