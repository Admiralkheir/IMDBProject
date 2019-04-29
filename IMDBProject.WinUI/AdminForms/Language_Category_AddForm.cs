using IMDBProject.BLL.IMDBService;
using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBProject.WinUI.AdminForms
{

    public partial class Language_Category_AddForm : Form
    {
        LanguageService _languageService;
        CategoryService _categoryService;

        public Language_Category_AddForm()
        {
            InitializeComponent();
            _languageService = new LanguageService();
            _categoryService = new CategoryService();
        }

        private void btnDilEkle_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (_languageService.GetAllLanguagesService()
                    .Where(x => x.LanguageName == txtDilEkle.Text)
                    .FirstOrDefault() != null)
            {
                errorProvider1.SetError(txtDilEkle, txtDilEkle.Text + " Daha Önce Eklenmiş.");
                return;
            }
            else
            {
                Language language = new Language();
                language.LanguageName = txtDilEkle.Text;
                language.CreateDate = DateTime.Now;
                int durum = _languageService.AddLanguageService(language);
                if (durum > 0)
                {
                    MessageBox.Show("Dil başarıyla eklendi");
                }
                else
                {
                    MessageBox.Show("Eklenemedi");
                }
            }
            txtDilEkle.Clear();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (_categoryService.GetAllCategoriesService()
                   .Where(x => x.CategoryName == txtKategoriEkle.Text)
                   .FirstOrDefault() != null)
            {
                errorProvider1.SetError(txtKategoriEkle, txtKategoriEkle.Text + " Daha Önce Eklenmiş.");
                return;
            }
            else
            {
                Category category = new Category();
                category.CategoryName = txtKategoriEkle.Text;
                category.CreateDate = DateTime.Now;
                int durum = _categoryService.AddCategoryService(category);
                if (durum > 0)
                {
                    MessageBox.Show("Kategori başarıyla eklendi");
                }
                else
                {
                    MessageBox.Show("Eklenemedi");
                }
                txtKategoriEkle.Clear();
            }

        }
    }
}
