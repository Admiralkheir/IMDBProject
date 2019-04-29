using IMDBProject.BLL.IMDBService;
using IMDBProject.Entities.DTO;
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

namespace IMDBProject.WinUI.UserForms
{
    public partial class FilmFilterForm : Form
    {
        FilmServices _filmServices;
        CountryService _countryService;
        DirectorService _directorService;
        ActorService _actorService;
        CategoryService _categoryService;
        RatingServices _ratingService;

        public static FilmFiltreDTO filmFiltreDTONesne;
        public FilmFilterForm()
        {
            InitializeComponent();
            _filmServices = new FilmServices();
            _countryService = new CountryService();
            _directorService = new DirectorService();
            _actorService = new ActorService();
            _categoryService = new CategoryService();
            _ratingService = new RatingServices();
            ltwFilmAra.ItemSelectionChanged += LtwFilmAra_ItemSelectionChanged;
            ltvDetaylıAra.ItemSelectionChanged += LtvDetaylıAra_ItemSelectionChanged;
            listviewAraDoldur();
            listviewDetayliAraDoldur();

            cbKategori.DisplayMember = "CategoryName";
            cbKategori.ValueMember = "CategoryID";
            cbKategori.DataSource = _categoryService.GetAllCategoriesService();
            cbUlke.DisplayMember = "CountryName";
            cbUlke.ValueMember = "CountryID";
            cbUlke.DataSource = _countryService.GetAllCountriesService();
        }

        private void LtvDetaylıAra_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            filmFiltreDTONesne = ((FilmFiltreDTO)e.Item.Tag);
            MainForm.ChildForm(new FilmForm());
        }
        private void LtwFilmAra_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            filmFiltreDTONesne = ((FilmFiltreDTO)e.Item.Tag);
            MainForm.ChildForm(new FilmForm());
        }

        public void listviewAraDoldur()
        {
            ltwFilmAra.Items.Clear();
            List<FilmFiltreDTO> filmListesi = _filmServices.GetFilmsRating(null);
            foreach (FilmFiltreDTO film in filmListesi)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = film.FilmName;
                lvi.SubItems.Add(film.Category);
                lvi.SubItems.Add(film.Point.ToString());
                lvi.Tag = film;
                ltwFilmAra.Items.Add(lvi);
            }
        }
        public void listviewDetayliAraDoldur()
        {
            ltvDetaylıAra.Items.Clear();
            List<FilmFiltreDTO> filmListesi = _filmServices.GetFilmsRating(null);
            foreach (FilmFiltreDTO film in filmListesi)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = film.FilmName;
                lvi.SubItems.Add(film.Category);
                lvi.SubItems.Add(film.Point.ToString());
                lvi.Tag = film;
                ltvDetaylıAra.Items.Add(lvi);
            }
        }


        private void txtFilmAra_TextChanged(object sender, EventArgs e)
        {
            ltwFilmAra.Items.Clear();
            List<FilmFiltreDTO> filmListesi = _filmServices.GetFilmsRating(txtFilmAra.Text);
            foreach (FilmFiltreDTO film in filmListesi)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = film.FilmName;
                lvi.SubItems.Add(film.Category);
                lvi.SubItems.Add(film.Point.ToString());
                lvi.Tag = film;
                ltwFilmAra.Items.Add(lvi);
            }
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            ltvDetaylıAra.Items.Clear();
            List<Film> films = null;
            if (string.IsNullOrEmpty(txtOyuncu.Text) && !string.IsNullOrEmpty(txtYonetmen.Text))
            {
                films = _filmServices.GetAllFilmService().ToList()
                .Where(f => f.Category.Any(any => any.CategoryID == Convert.ToInt16(cbKategori.SelectedValue)))
                .Where(f => f.Country.Any(any => any.CountryID == Convert.ToInt16(cbUlke.SelectedValue)))
                .Where(f => f.Director.Any(any => any.DirectorName.ToLower().Contains(txtYonetmen.Text.ToLower())) || f.Director.Any(any => any.DirectorSurname.ToLower().Contains(txtYonetmen.Text.ToLower())))
                .ToList();
            }
            else if (string.IsNullOrEmpty(txtYonetmen.Text) && !string.IsNullOrEmpty(txtOyuncu.Text))
            {
                films = _filmServices.GetAllFilmService().ToList()
                .Where(f => f.Category.Any(any => any.CategoryID == Convert.ToInt16(cbKategori.SelectedValue)))
                .Where(f => f.Country.Any(any => any.CountryID == Convert.ToInt16(cbUlke.SelectedValue)))
                .Where(f => f.Actor.Any(any => any.ActorName.ToLower().Contains(txtOyuncu.Text.ToLower())) || f.Actor.Any(any => any.ActorSurname.ToLower().Contains(txtOyuncu.Text.ToLower())))
                .ToList();
            }
            else if (string.IsNullOrEmpty(txtOyuncu.Text) && string.IsNullOrEmpty(txtYonetmen.Text))
            {
                films = _filmServices.GetAllFilmService().ToList()
                .Where(f => f.Category.Any(any => any.CategoryID == Convert.ToInt16(cbKategori.SelectedValue)))
                .Where(f => f.Country.Any(any => any.CountryID == Convert.ToInt16(cbUlke.SelectedValue)))
                .ToList();
            }
            else
            {
                films = _filmServices.GetAllFilmService().ToList()
                .Where(f => f.Category.Any(any => any.CategoryID == Convert.ToInt16(cbKategori.SelectedValue)))
                .Where(f => f.Country.Any(any => any.CountryID == Convert.ToInt16(cbUlke.SelectedValue)))
                .Where(f => f.Actor.Any(any => any.ActorName.ToLower().Contains(txtOyuncu.Text.ToLower())) || f.Actor.Any(any => any.ActorSurname.ToLower().Contains(txtOyuncu.Text.ToLower())))
                .Where(f => f.Director.Any(any => any.DirectorName.ToLower().Contains(txtYonetmen.Text.ToLower())) || f.Director.Any(any => any.DirectorSurname.ToLower().Contains(txtYonetmen.Text.ToLower())))
                .ToList();
            }
            
            List<FilmFiltreDTO> tablo = (from film in films
                                         join rating in _ratingService.GetAllRatingService()
                                         on film.FilmID
                                         equals rating.FilmID
                                         group rating by rating.Film.FilmName
                                         into filmGrup
                                         select new FilmFiltreDTO
                                         {
                                             FilmID = filmGrup.FirstOrDefault().FilmID,
                                             FilmName = filmGrup.Key,
                                             Point = filmGrup.Average(x => x.Point),
                                             Category = filmGrup.FirstOrDefault().Film.Category.FirstOrDefault().CategoryName

                                         }).ToList();



            foreach (FilmFiltreDTO film in tablo)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = film.FilmName;
                lvi.SubItems.Add(film.Category);
                lvi.SubItems.Add(film.Point.ToString());
                lvi.Tag = film;
                ltvDetaylıAra.Items.Add(lvi);
            }
        }
    }
}
