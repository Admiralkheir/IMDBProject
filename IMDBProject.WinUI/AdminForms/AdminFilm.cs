using IMDBProject.BLL.IMDBService;
using IMDBProject.Entities.Models;
using IMDBProject.WinUI.UserForms;
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
    public partial class AdminFilm : Form
    {
        public List<int> dizi = new List<int>();
        public AdminFilm()
        {
            InitializeComponent();
            lstOyuncu.ItemSelectionChanged += LstOyuncu_ItemSelectionChanged;
            FİlmleriListVieweDoldur();
        }

        private void LstOyuncu_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            dizi.Clear();
            for (int i = 0; i < lstYonetmen.SelectedItems.Count; i++)
            {
                dizi.Add(lstYonetmen.SelectedItems[i].Index);
            }
            for (int i = 0; i < dizi.Count; i++)
            {
                lstYonetmen.Items[dizi[i]].Selected = true;
            }
        }

        CategoryService categoryService = new CategoryService();
        CountryService countryService = new CountryService();
        LanguageService languageService = new LanguageService();
        DirectorService directorService = new DirectorService();
        ActorService actorService = new ActorService();
        FilmServices FilmServices = new FilmServices();
        RatingServices RatingService = new RatingServices();
        string path;

        void YonetmenleriListVieweDoldur()
        {
            foreach (Director d in directorService.GetAllDirectorService())
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = d.DirectorName;
                lvi.SubItems.Add(d.DirectorSurname);
                lvi.SubItems.Add(d.BirthDate.ToString());
                lvi.Tag = d.DirectorID;

                lstYonetmen.Items.Add(lvi);
            }
        }

        void OyunculariListVieweDoldur()
        {
            foreach (Actor a in actorService.GetAllActorService())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = a.ActorName;
                lvi.SubItems.Add(a.ActorSurname);
                lvi.SubItems.Add(a.BirthDate.ToString());
                lvi.Tag = a.ActorID;

                lstOyuncu.Items.Add(lvi);
            }
        }

        void FİlmleriListVieweDoldur()
        {
            lstFilm.Items.Clear();
            foreach (Film f in FilmServices.GetAllFilmService())
            {
                ListViewItem lvi = new ListViewItem();
                List<Category> kategori = new List<Category>();

                string ad = null;
                kategori = f.Category.ToList();

                lvi.Text = f.FilmName;
                lvi.SubItems.Add(f.ReleaseDate.Year.ToString());

                foreach (Category item in kategori)
                {
                    ad += item.CategoryName + " ";
                }
                lvi.SubItems.Add(ad);
                lvi.Tag = f;

                lstFilm.Items.Add(lvi);
            }
        }

        private void AdminFilm_Load(object sender, EventArgs e)
        {
            cbKategori.DisplayMember = "CategoryName";
            cbKategori.ValueMember = "CategoryID";
            cbKategori.DataSource = categoryService.GetAllCategoriesService();

            cbUlke.DisplayMember = "CountryName";
            cbUlke.ValueMember = "CountryID";
            cbUlke.DataSource = countryService.GetAllCountriesService();

            cbDil.DisplayMember = "LanguageName";
            cbDil.ValueMember = "LanguageID";
            cbDil.DataSource = languageService.GetAllLanguagesService();

            YonetmenleriListVieweDoldur();
            OyunculariListVieweDoldur();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Film yenifilm = new Film();
            yenifilm.PosterUrl = path;
            yenifilm.FilmName = txtFilmAdi.Text;
            yenifilm.ReleaseDate = dateTimePicker1.Value;
            yenifilm.FilmSummary = txtBio.Text;
            yenifilm.CreateDate = DateTime.Now;
            yenifilm.LanguageID = Convert.ToInt16(cbDil.SelectedValue);
            FilmServices.AddFilmService(yenifilm);


            //Film film = FilmServices.GetByIdFilmService(yenifilm.FilmID);
            yenifilm.Category.Add(categoryService.GetByIdCategoryService(Convert.ToInt16(cbKategori.SelectedValue)));
            yenifilm.Country.Add(countryService.GetByIdCountryService(Convert.ToInt16(cbUlke.SelectedValue)));

            for (int i = 0; i < lstOyuncu.SelectedItems.Count; i++)
            {
                yenifilm.Actor.Add(actorService.GetByIDActorService(Convert.ToUInt16(lstOyuncu.SelectedItems[i].Tag)));
            }

            for (int i = 0; i < lstYonetmen.SelectedItems.Count; i++)
            {
                yenifilm.Director.Add(directorService.GetByIdDirectorService(Convert.ToUInt16(lstYonetmen.SelectedItems[i].Tag)));
            }

            if (FilmServices.UpdateFilmService(yenifilm) > 0) //Film eklendiğinde
            {
                MessageBox.Show(yenifilm.FilmName + " Filmi Başarıyla Eklendi");
                FİlmleriListVieweDoldur();
            }
            else
            {
                MessageBox.Show("Hata. Eklenemedi");
            }
            Rating yeniRating = new Rating();
            yeniRating.Comment = "Admin Yorum";
            yeniRating.CreateDate = DateTime.Now;
            yeniRating.Point = 3;
            yeniRating.FilmID = yenifilm.FilmID;
            yeniRating.UserID = LoginForm._userID;  //this user is always admin
            RatingService.AddRatingService(yeniRating);

        }


        private void btnAfisEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string url = openFileDialog1.SafeFileName;
            path = "\\Images\\FilmImages\\" + url;
            //string path = Application.StartupPath + yeniURL;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Film silinecekfilm = new Film();
            silinecekfilm = (Film)lstFilm.SelectedItems[0].Tag;

            FilmServices.DeleteFilmService(silinecekfilm);
            FİlmleriListVieweDoldur();

        }
    }
}
