namespace IMDBProject.WinUI.AdminForms
{
    partial class AdminFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFilm));
            this.tbcFilmAdmin = new System.Windows.Forms.TabControl();
            this.tbpEkle = new System.Windows.Forms.TabPage();
            this.cbDil = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lstOyuncu = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstYonetmen = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAfisEkle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbUlke = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpSil = new System.Windows.Forms.TabPage();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstFilm = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbcFilmAdmin.SuspendLayout();
            this.tbpEkle.SuspendLayout();
            this.tbpSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcFilmAdmin
            // 
            this.tbcFilmAdmin.Controls.Add(this.tbpEkle);
            this.tbcFilmAdmin.Controls.Add(this.tbpSil);
            this.tbcFilmAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcFilmAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbcFilmAdmin.Location = new System.Drawing.Point(0, 0);
            this.tbcFilmAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcFilmAdmin.Name = "tbcFilmAdmin";
            this.tbcFilmAdmin.SelectedIndex = 0;
            this.tbcFilmAdmin.Size = new System.Drawing.Size(969, 747);
            this.tbcFilmAdmin.TabIndex = 6;
            // 
            // tbpEkle
            // 
            this.tbpEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbpEkle.BackgroundImage")));
            this.tbpEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbpEkle.Controls.Add(this.cbDil);
            this.tbpEkle.Controls.Add(this.label11);
            this.tbpEkle.Controls.Add(this.lstOyuncu);
            this.tbpEkle.Controls.Add(this.lstYonetmen);
            this.tbpEkle.Controls.Add(this.btnAfisEkle);
            this.tbpEkle.Controls.Add(this.btnEkle);
            this.tbpEkle.Controls.Add(this.txtFilmAdi);
            this.tbpEkle.Controls.Add(this.dateTimePicker1);
            this.tbpEkle.Controls.Add(this.txtBio);
            this.tbpEkle.Controls.Add(this.cbKategori);
            this.tbpEkle.Controls.Add(this.cbUlke);
            this.tbpEkle.Controls.Add(this.label10);
            this.tbpEkle.Controls.Add(this.label9);
            this.tbpEkle.Controls.Add(this.label8);
            this.tbpEkle.Controls.Add(this.label7);
            this.tbpEkle.Controls.Add(this.label6);
            this.tbpEkle.Controls.Add(this.label5);
            this.tbpEkle.Controls.Add(this.label4);
            this.tbpEkle.Controls.Add(this.label3);
            this.tbpEkle.Controls.Add(this.label2);
            this.tbpEkle.Controls.Add(this.label1);
            this.tbpEkle.Location = new System.Drawing.Point(4, 31);
            this.tbpEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpEkle.Name = "tbpEkle";
            this.tbpEkle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpEkle.Size = new System.Drawing.Size(961, 712);
            this.tbpEkle.TabIndex = 0;
            this.tbpEkle.Text = "Ekle";
            this.tbpEkle.UseVisualStyleBackColor = true;
            // 
            // cbDil
            // 
            this.cbDil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDil.FormattingEnabled = true;
            this.cbDil.Location = new System.Drawing.Point(143, 538);
            this.cbDil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDil.Name = "cbDil";
            this.cbDil.Size = new System.Drawing.Size(319, 30);
            this.cbDil.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(68, 548);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = "Dil : ";
            // 
            // lstOyuncu
            // 
            this.lstOyuncu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstOyuncu.FullRowSelect = true;
            this.lstOyuncu.Location = new System.Drawing.Point(620, 281);
            this.lstOyuncu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOyuncu.Name = "lstOyuncu";
            this.lstOyuncu.Size = new System.Drawing.Size(327, 218);
            this.lstOyuncu.TabIndex = 26;
            this.lstOyuncu.UseCompatibleStateImageBehavior = false;
            this.lstOyuncu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ad";
            this.columnHeader7.Width = 88;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Soyad";
            this.columnHeader8.Width = 108;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Doğum Tarihi";
            this.columnHeader9.Width = 125;
            // 
            // lstYonetmen
            // 
            this.lstYonetmen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader5});
            this.lstYonetmen.FullRowSelect = true;
            this.lstYonetmen.Location = new System.Drawing.Point(620, 39);
            this.lstYonetmen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstYonetmen.Name = "lstYonetmen";
            this.lstYonetmen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstYonetmen.Size = new System.Drawing.Size(327, 206);
            this.lstYonetmen.TabIndex = 25;
            this.lstYonetmen.UseCompatibleStateImageBehavior = false;
            this.lstYonetmen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ad";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Soyad";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Doğum Tarihi";
            this.columnHeader5.Width = 119;
            // 
            // btnAfisEkle
            // 
            this.btnAfisEkle.Location = new System.Drawing.Point(143, 39);
            this.btnAfisEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAfisEkle.Name = "btnAfisEkle";
            this.btnAfisEkle.Size = new System.Drawing.Size(323, 30);
            this.btnAfisEkle.TabIndex = 24;
            this.btnAfisEkle.Text = "Afiş Seç";
            this.btnAfisEkle.UseVisualStyleBackColor = true;
            this.btnAfisEkle.Click += new System.EventHandler(this.btnAfisEkle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ForeColor = System.Drawing.Color.Maroon;
            this.btnEkle.Location = new System.Drawing.Point(659, 554);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(187, 49);
            this.btnEkle.TabIndex = 23;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmAdi.Location = new System.Drawing.Point(143, 90);
            this.txtFilmAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(319, 30);
            this.txtFilmAdi.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 139);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 30);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // txtBio
            // 
            this.txtBio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBio.Location = new System.Drawing.Point(143, 193);
            this.txtBio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(319, 246);
            this.txtBio.TabIndex = 17;
            // 
            // cbKategori
            // 
            this.cbKategori.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(143, 476);
            this.cbKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(319, 30);
            this.cbKategori.TabIndex = 16;
            // 
            // cbUlke
            // 
            this.cbUlke.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUlke.FormattingEnabled = true;
            this.cbUlke.Location = new System.Drawing.Point(143, 599);
            this.cbUlke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUlke.Name = "cbUlke";
            this.cbUlke.Size = new System.Drawing.Size(319, 30);
            this.cbUlke.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(709, 156);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 22);
            this.label10.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(515, 281);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Oyuncu : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(493, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Yönetmen : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(52, 603);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ülke : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(7, 441);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 23);
            this.label6.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(16, 480);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kategori : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(59, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Özet : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(76, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yıl :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Film Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Afiş : ";
            // 
            // tbpSil
            // 
            this.tbpSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbpSil.BackgroundImage")));
            this.tbpSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbpSil.Controls.Add(this.btnSil);
            this.tbpSil.Controls.Add(this.lstFilm);
            this.tbpSil.Location = new System.Drawing.Point(4, 31);
            this.tbpSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpSil.Name = "tbpSil";
            this.tbpSil.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpSil.Size = new System.Drawing.Size(961, 712);
            this.tbpSil.TabIndex = 1;
            this.tbpSil.Text = "Sil";
            this.tbpSil.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.ForeColor = System.Drawing.Color.Maroon;
            this.btnSil.Location = new System.Drawing.Point(659, 554);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(187, 49);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstFilm
            // 
            this.lstFilm.BackColor = System.Drawing.Color.Snow;
            this.lstFilm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstFilm.FullRowSelect = true;
            this.lstFilm.GridLines = true;
            this.lstFilm.Location = new System.Drawing.Point(39, 33);
            this.lstFilm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstFilm.Name = "lstFilm";
            this.lstFilm.Size = new System.Drawing.Size(805, 496);
            this.lstFilm.TabIndex = 0;
            this.lstFilm.UseCompatibleStateImageBehavior = false;
            this.lstFilm.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Film Adı";
            this.columnHeader1.Width = 218;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yıl";
            this.columnHeader2.Width = 149;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategori";
            this.columnHeader3.Width = 199;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 747);
            this.Controls.Add(this.tbcFilmAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Film Ekle/Sil";
            this.Load += new System.EventHandler(this.AdminFilm_Load);
            this.tbcFilmAdmin.ResumeLayout(false);
            this.tbpEkle.ResumeLayout(false);
            this.tbpEkle.PerformLayout();
            this.tbpSil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcFilmAdmin;
        private System.Windows.Forms.TabPage tbpEkle;
        private System.Windows.Forms.TabPage tbpSil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ComboBox cbUlke;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListView lstFilm;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAfisEkle;
        private System.Windows.Forms.ListView lstOyuncu;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lstYonetmen;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbDil;
        private System.Windows.Forms.Label label11;
    }
}