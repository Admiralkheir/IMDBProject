namespace IMDBProject.WinUI.AdminForms
{
    partial class Language_Category_AddForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Language_Category_AddForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDilEkle = new System.Windows.Forms.TextBox();
            this.btnDilEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtKategoriEkle = new System.Windows.Forms.TextBox();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 607);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.txtDilEkle);
            this.tabPage1.Controls.Add(this.btnDilEkle);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(719, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dil Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDilEkle
            // 
            this.txtDilEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDilEkle.Location = new System.Drawing.Point(231, 154);
            this.txtDilEkle.Name = "txtDilEkle";
            this.txtDilEkle.Size = new System.Drawing.Size(291, 26);
            this.txtDilEkle.TabIndex = 12;
            // 
            // btnDilEkle
            // 
            this.btnDilEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDilEkle.ForeColor = System.Drawing.Color.Maroon;
            this.btnDilEkle.Location = new System.Drawing.Point(289, 203);
            this.btnDilEkle.Name = "btnDilEkle";
            this.btnDilEkle.Size = new System.Drawing.Size(153, 40);
            this.btnDilEkle.TabIndex = 11;
            this.btnDilEkle.Text = "Dili Ekle";
            this.btnDilEkle.UseVisualStyleBackColor = true;
            this.btnDilEkle.Click += new System.EventHandler(this.btnDilEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(156, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dil Adı:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.txtKategoriEkle);
            this.tabPage2.Controls.Add(this.btnKategoriEkle);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(719, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kategori Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtKategoriEkle
            // 
            this.txtKategoriEkle.Location = new System.Drawing.Point(277, 160);
            this.txtKategoriEkle.Name = "txtKategoriEkle";
            this.txtKategoriEkle.Size = new System.Drawing.Size(268, 26);
            this.txtKategoriEkle.TabIndex = 15;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriEkle.ForeColor = System.Drawing.Color.Maroon;
            this.btnKategoriEkle.Location = new System.Drawing.Point(329, 209);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(153, 40);
            this.btnKategoriEkle.TabIndex = 14;
            this.btnKategoriEkle.Text = "Kategoriyi Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(172, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kategori Adı:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Language_Category_AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 607);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Language_Category_AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dil / Kategori Ekleme Paneli";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDilEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategoriEkle;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDilEkle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}