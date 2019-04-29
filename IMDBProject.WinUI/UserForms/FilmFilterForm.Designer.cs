namespace IMDBProject.WinUI.UserForms
{
    partial class FilmFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmFilterForm));
            this.tbc_FilmFilter = new System.Windows.Forms.TabControl();
            this.tbp_Filter = new System.Windows.Forms.TabPage();
            this.lblFilm = new System.Windows.Forms.Label();
            this.ltwFilmAra = new System.Windows.Forms.ListView();
            this.filmAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filmKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filmPuani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFilmAra = new System.Windows.Forms.TextBox();
            this.tbp_DetailFilter = new System.Windows.Forms.TabPage();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.cbUlke = new System.Windows.Forms.ComboBox();
            this.txtOyuncu = new System.Windows.Forms.TextBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.ltvDetaylıAra = new System.Windows.Forms.ListView();
            this.FilmAdiDetay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilmAdiKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbc_FilmFilter.SuspendLayout();
            this.tbp_Filter.SuspendLayout();
            this.tbp_DetailFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_FilmFilter
            // 
            this.tbc_FilmFilter.Controls.Add(this.tbp_Filter);
            this.tbc_FilmFilter.Controls.Add(this.tbp_DetailFilter);
            this.tbc_FilmFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_FilmFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbc_FilmFilter.Location = new System.Drawing.Point(0, 0);
            this.tbc_FilmFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbc_FilmFilter.Name = "tbc_FilmFilter";
            this.tbc_FilmFilter.SelectedIndex = 0;
            this.tbc_FilmFilter.Size = new System.Drawing.Size(969, 747);
            this.tbc_FilmFilter.TabIndex = 0;
            // 
            // tbp_Filter
            // 
            this.tbp_Filter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbp_Filter.BackgroundImage")));
            this.tbp_Filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbp_Filter.Controls.Add(this.lblFilm);
            this.tbp_Filter.Controls.Add(this.ltwFilmAra);
            this.tbp_Filter.Controls.Add(this.txtFilmAra);
            this.tbp_Filter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbp_Filter.Location = new System.Drawing.Point(4, 31);
            this.tbp_Filter.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_Filter.Name = "tbp_Filter";
            this.tbp_Filter.Padding = new System.Windows.Forms.Padding(4);
            this.tbp_Filter.Size = new System.Drawing.Size(961, 712);
            this.tbp_Filter.TabIndex = 0;
            this.tbp_Filter.Text = "Ara";
            this.tbp_Filter.UseVisualStyleBackColor = true;
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilm.ForeColor = System.Drawing.Color.Maroon;
            this.lblFilm.Location = new System.Drawing.Point(99, 60);
            this.lblFilm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(96, 23);
            this.lblFilm.TabIndex = 2;
            this.lblFilm.Text = "Film Adı : ";
            // 
            // ltwFilmAra
            // 
            this.ltwFilmAra.BackColor = System.Drawing.Color.MintCream;
            this.ltwFilmAra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filmAdi,
            this.filmKategori,
            this.filmPuani});
            this.ltwFilmAra.FullRowSelect = true;
            this.ltwFilmAra.GridLines = true;
            this.ltwFilmAra.Location = new System.Drawing.Point(21, 118);
            this.ltwFilmAra.Margin = new System.Windows.Forms.Padding(4);
            this.ltwFilmAra.Name = "ltwFilmAra";
            this.ltwFilmAra.Size = new System.Drawing.Size(905, 543);
            this.ltwFilmAra.TabIndex = 1;
            this.ltwFilmAra.UseCompatibleStateImageBehavior = false;
            this.ltwFilmAra.View = System.Windows.Forms.View.Details;
            // 
            // filmAdi
            // 
            this.filmAdi.Text = "Film Adı";
            this.filmAdi.Width = 317;
            // 
            // filmKategori
            // 
            this.filmKategori.Text = "Kategori";
            this.filmKategori.Width = 230;
            // 
            // filmPuani
            // 
            this.filmPuani.Text = "Puan";
            this.filmPuani.Width = 348;
            // 
            // txtFilmAra
            // 
            this.txtFilmAra.BackColor = System.Drawing.Color.MintCream;
            this.txtFilmAra.Location = new System.Drawing.Point(209, 57);
            this.txtFilmAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilmAra.Name = "txtFilmAra";
            this.txtFilmAra.Size = new System.Drawing.Size(529, 30);
            this.txtFilmAra.TabIndex = 0;
            this.txtFilmAra.TextChanged += new System.EventHandler(this.txtFilmAra_TextChanged);
            // 
            // tbp_DetailFilter
            // 
            this.tbp_DetailFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbp_DetailFilter.BackgroundImage")));
            this.tbp_DetailFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbp_DetailFilter.Controls.Add(this.btnFiltre);
            this.tbp_DetailFilter.Controls.Add(this.cbUlke);
            this.tbp_DetailFilter.Controls.Add(this.txtOyuncu);
            this.tbp_DetailFilter.Controls.Add(this.txtYonetmen);
            this.tbp_DetailFilter.Controls.Add(this.cbKategori);
            this.tbp_DetailFilter.Controls.Add(this.ltvDetaylıAra);
            this.tbp_DetailFilter.Controls.Add(this.label4);
            this.tbp_DetailFilter.Controls.Add(this.label3);
            this.tbp_DetailFilter.Controls.Add(this.label2);
            this.tbp_DetailFilter.Controls.Add(this.label1);
            this.tbp_DetailFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbp_DetailFilter.Location = new System.Drawing.Point(4, 31);
            this.tbp_DetailFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbp_DetailFilter.Name = "tbp_DetailFilter";
            this.tbp_DetailFilter.Padding = new System.Windows.Forms.Padding(4);
            this.tbp_DetailFilter.Size = new System.Drawing.Size(961, 712);
            this.tbp_DetailFilter.TabIndex = 1;
            this.tbp_DetailFilter.Text = "Detaylı Ara";
            this.tbp_DetailFilter.UseVisualStyleBackColor = true;
            // 
            // btnFiltre
            // 
            this.btnFiltre.ForeColor = System.Drawing.Color.Maroon;
            this.btnFiltre.Location = new System.Drawing.Point(772, 133);
            this.btnFiltre.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(155, 47);
            this.btnFiltre.TabIndex = 10;
            this.btnFiltre.Text = "Filtrele";
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // cbUlke
            // 
            this.cbUlke.BackColor = System.Drawing.Color.MintCream;
            this.cbUlke.FormattingEnabled = true;
            this.cbUlke.Location = new System.Drawing.Point(168, 75);
            this.cbUlke.Margin = new System.Windows.Forms.Padding(4);
            this.cbUlke.Name = "cbUlke";
            this.cbUlke.Size = new System.Drawing.Size(300, 30);
            this.cbUlke.TabIndex = 9;
            // 
            // txtOyuncu
            // 
            this.txtOyuncu.BackColor = System.Drawing.Color.MintCream;
            this.txtOyuncu.Location = new System.Drawing.Point(625, 81);
            this.txtOyuncu.Margin = new System.Windows.Forms.Padding(4);
            this.txtOyuncu.Name = "txtOyuncu";
            this.txtOyuncu.Size = new System.Drawing.Size(300, 30);
            this.txtOyuncu.TabIndex = 8;
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.BackColor = System.Drawing.Color.MintCream;
            this.txtYonetmen.Location = new System.Drawing.Point(625, 30);
            this.txtYonetmen.Margin = new System.Windows.Forms.Padding(4);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(300, 30);
            this.txtYonetmen.TabIndex = 7;
            // 
            // cbKategori
            // 
            this.cbKategori.BackColor = System.Drawing.Color.MintCream;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(168, 30);
            this.cbKategori.Margin = new System.Windows.Forms.Padding(4);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(300, 30);
            this.cbKategori.TabIndex = 6;
            // 
            // ltvDetaylıAra
            // 
            this.ltvDetaylıAra.BackColor = System.Drawing.Color.MintCream;
            this.ltvDetaylıAra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FilmAdiDetay,
            this.FilmAdiKategori,
            this.columnHeader1});
            this.ltvDetaylıAra.FullRowSelect = true;
            this.ltvDetaylıAra.GridLines = true;
            this.ltvDetaylıAra.Location = new System.Drawing.Point(35, 210);
            this.ltvDetaylıAra.Margin = new System.Windows.Forms.Padding(4);
            this.ltvDetaylıAra.Name = "ltvDetaylıAra";
            this.ltvDetaylıAra.Size = new System.Drawing.Size(891, 466);
            this.ltvDetaylıAra.TabIndex = 5;
            this.ltvDetaylıAra.UseCompatibleStateImageBehavior = false;
            this.ltvDetaylıAra.View = System.Windows.Forms.View.Details;
            // 
            // FilmAdiDetay
            // 
            this.FilmAdiDetay.Text = "Film Adı";
            this.FilmAdiDetay.Width = 302;
            // 
            // FilmAdiKategori
            // 
            this.FilmAdiKategori.Text = "Kategori";
            this.FilmAdiKategori.Width = 247;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Puan";
            this.columnHeader1.Width = 244;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(64, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ülkeler : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(497, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yönetmen : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(523, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oyuncu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategoriler : ";
            // 
            // FilmFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 747);
            this.Controls.Add(this.tbc_FilmFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FilmFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Film Arama";
            this.tbc_FilmFilter.ResumeLayout(false);
            this.tbp_Filter.ResumeLayout(false);
            this.tbp_Filter.PerformLayout();
            this.tbp_DetailFilter.ResumeLayout(false);
            this.tbp_DetailFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_FilmFilter;
        private System.Windows.Forms.TabPage tbp_Filter;
        private System.Windows.Forms.TabPage tbp_DetailFilter;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.ListView ltwFilmAra;
        private System.Windows.Forms.ColumnHeader filmAdi;
        private System.Windows.Forms.ColumnHeader filmKategori;
        private System.Windows.Forms.ColumnHeader filmPuani;
        private System.Windows.Forms.TextBox txtFilmAra;
        private System.Windows.Forms.ComboBox cbUlke;
        private System.Windows.Forms.TextBox txtOyuncu;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ListView ltvDetaylıAra;
        private System.Windows.Forms.ColumnHeader FilmAdiDetay;
        private System.Windows.Forms.ColumnHeader FilmAdiKategori;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltre;
    }
}