namespace IMDBProject.WinUI.AdminForms
{
    partial class CountryCRUDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountryCRUDForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtUlkeEkle = new System.Windows.Forms.TextBox();
            this.btnUlkeEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUlkeGuncelle = new System.Windows.Forms.TabPage();
            this.btnUlkGuncelle = new System.Windows.Forms.Button();
            this.txtUlkeGuncelle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGuncellenecekUlke = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.btnUlkeGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.btnUlkeGuncelle);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 607);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.txtUlkeEkle);
            this.tabPage1.Controls.Add(this.btnUlkeEkle);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(719, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ülke Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtUlkeEkle
            // 
            this.txtUlkeEkle.Location = new System.Drawing.Point(191, 169);
            this.txtUlkeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.txtUlkeEkle.Name = "txtUlkeEkle";
            this.txtUlkeEkle.Size = new System.Drawing.Size(318, 26);
            this.txtUlkeEkle.TabIndex = 3;
            // 
            // btnUlkeEkle
            // 
            this.btnUlkeEkle.ForeColor = System.Drawing.Color.Maroon;
            this.btnUlkeEkle.Location = new System.Drawing.Point(235, 235);
            this.btnUlkeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUlkeEkle.Name = "btnUlkeEkle";
            this.btnUlkeEkle.Size = new System.Drawing.Size(230, 58);
            this.btnUlkeEkle.TabIndex = 2;
            this.btnUlkeEkle.Text = "Ülkeyi Ekle";
            this.btnUlkeEkle.UseVisualStyleBackColor = true;
            this.btnUlkeEkle.Click += new System.EventHandler(this.btnUlkeEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(67, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ülke Adı:";
            // 
            // btnUlkeGuncelle
            // 
            this.btnUlkeGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUlkeGuncelle.BackgroundImage")));
            this.btnUlkeGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUlkeGuncelle.Controls.Add(this.btnUlkGuncelle);
            this.btnUlkeGuncelle.Controls.Add(this.txtUlkeGuncelle);
            this.btnUlkeGuncelle.Controls.Add(this.label4);
            this.btnUlkeGuncelle.Controls.Add(this.cmbGuncellenecekUlke);
            this.btnUlkeGuncelle.Controls.Add(this.label2);
            this.btnUlkeGuncelle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUlkeGuncelle.Location = new System.Drawing.Point(4, 29);
            this.btnUlkeGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUlkeGuncelle.Name = "btnUlkeGuncelle";
            this.btnUlkeGuncelle.Padding = new System.Windows.Forms.Padding(4);
            this.btnUlkeGuncelle.Size = new System.Drawing.Size(719, 574);
            this.btnUlkeGuncelle.TabIndex = 1;
            this.btnUlkeGuncelle.Text = "Ülke Güncelle";
            this.btnUlkeGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnUlkGuncelle
            // 
            this.btnUlkGuncelle.ForeColor = System.Drawing.Color.Maroon;
            this.btnUlkGuncelle.Location = new System.Drawing.Point(291, 276);
            this.btnUlkGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUlkGuncelle.Name = "btnUlkGuncelle";
            this.btnUlkGuncelle.Size = new System.Drawing.Size(230, 60);
            this.btnUlkGuncelle.TabIndex = 3;
            this.btnUlkGuncelle.Text = "Güncelle";
            this.btnUlkGuncelle.UseVisualStyleBackColor = true;
            this.btnUlkGuncelle.Click += new System.EventHandler(this.btnUlkGuncelle_Click);
            // 
            // txtUlkeGuncelle
            // 
            this.txtUlkeGuncelle.Location = new System.Drawing.Point(248, 216);
            this.txtUlkeGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.txtUlkeGuncelle.Name = "txtUlkeGuncelle";
            this.txtUlkeGuncelle.Size = new System.Drawing.Size(335, 26);
            this.txtUlkeGuncelle.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(78, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yeni Ülke Adı:";
            // 
            // cmbGuncellenecekUlke
            // 
            this.cmbGuncellenecekUlke.FormattingEnabled = true;
            this.cmbGuncellenecekUlke.Location = new System.Drawing.Point(248, 144);
            this.cmbGuncellenecekUlke.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGuncellenecekUlke.Name = "cmbGuncellenecekUlke";
            this.cmbGuncellenecekUlke.Size = new System.Drawing.Size(335, 27);
            this.cmbGuncellenecekUlke.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(33, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Güncellenecek Ülke:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CountryCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 607);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CountryCRUDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ülke İşlem Paneli";
            this.Load += new System.EventHandler(this.CountryCRUDForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.btnUlkeGuncelle.ResumeLayout(false);
            this.btnUlkeGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtUlkeEkle;
        private System.Windows.Forms.Button btnUlkeEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage btnUlkeGuncelle;
        private System.Windows.Forms.Button btnUlkGuncelle;
        private System.Windows.Forms.TextBox txtUlkeGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGuncellenecekUlke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}