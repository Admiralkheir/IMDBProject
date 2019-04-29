using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMDBProject.BLL.IMDBService;
using IMDBProject.Entities.Models;
namespace IMDBProject.WinUI.UserForms
{
    public partial class FilmForm : Form
    {
        public DirectorService _directorService;
        public FilmServices _filmService;
        public RatingServices _ratingService;
        public static int _idAktor;//seçilen aktör id
        public static int _idYonetmen;//secilen yonetmen id
        Rating _rating;//secilen rating
        string _userName;
        public FilmForm()
        {
            _directorService = new DirectorService();
            _filmService = new FilmServices();
            _ratingService = new RatingServices();
            InitializeComponent();
        }

        private void lnkYonetmen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _idYonetmen = Convert.ToInt16(lnkYonetmen.Tag);
            MainForm.ChildForm(new DirectorForm());
        }

        private void lnkYonetmen2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _idYonetmen = Convert.ToInt16(lnkYonetmen2.Tag);
            MainForm.ChildForm(new DirectorForm());
        }

        private void lnkOyuncu1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _idAktor = Convert.ToInt16(lnkOyuncu1.Tag);
            MainForm.ChildForm(new ActorForm());
        }
        private void lnkOyuncu3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _idAktor = Convert.ToInt16(lnkOyuncu3.Tag);
            MainForm.ChildForm(new ActorForm());
        }

        private void lnkOyuncu2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _idAktor = Convert.ToInt16(lnkOyuncu2.Tag);
            MainForm.ChildForm(new ActorForm());
        }

        private void lnkOyuncu5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _idAktor = Convert.ToInt16(lnkOyuncu5.Tag);
            MainForm.ChildForm(new ActorForm());
        }

        private void lnkOyuncu4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _idAktor = Convert.ToInt16(lnkOyuncu4.Tag);
            MainForm.ChildForm(new ActorForm());
        }

        private void FilmForm_Load(object sender, EventArgs e)
        {
            List<Director> YonecticiListe = _filmService.GetFilmDirector(FilmFilterForm.filmFiltreDTONesne.FilmID).ToList();
            List<Actor> OyuncuListesi = _filmService.GetFilmActorFilmService(FilmFilterForm.filmFiltreDTONesne.FilmID).ToList();
            try
            {
                lnkYonetmen.Text = YonecticiListe[0].DirectorName;
                lnkYonetmen.Tag = YonecticiListe[0].DirectorID;

                lnkYonetmen.Visible = true;

                lnkYonetmen2.Text = YonecticiListe[1].DirectorName;
                lnkYonetmen2.Tag = YonecticiListe[1].DirectorID;
                lnkYonetmen2.Visible = true;
            }
            catch (Exception)
            {

            }
            rdb3.Checked = true;

            lnkOyuncu1.Text = OyuncuListesi[0].ActorName + " " + OyuncuListesi[0].ActorSurname;
            lnkOyuncu1.Tag = OyuncuListesi[0].ActorID;

            lnkOyuncu2.Text = OyuncuListesi[1].ActorName + " " + OyuncuListesi[1].ActorSurname;
            lnkOyuncu2.Tag = OyuncuListesi[1].ActorID;

            lnkOyuncu3.Text = OyuncuListesi[2].ActorName + " " + OyuncuListesi[2].ActorSurname;
            lnkOyuncu3.Tag = OyuncuListesi[2].ActorID;

            lnkOyuncu4.Text = OyuncuListesi[3].ActorName + " " + OyuncuListesi[3].ActorSurname;
            lnkOyuncu4.Tag = OyuncuListesi[3].ActorID;

            lnkOyuncu5.Text = OyuncuListesi[4].ActorName + " " + OyuncuListesi[4].ActorSurname;
            lnkOyuncu5.Tag = OyuncuListesi[4].ActorID;

            pcbFilmAfis.ImageLocation = Application.StartupPath + _filmService.GetByIdFilmService(FilmFilterForm.filmFiltreDTONesne.FilmID).PosterUrl;
            lblFilmAdi.Text = _filmService.GetByIdFilmService(FilmFilterForm.filmFiltreDTONesne.FilmID).FilmName;
            lblPoint.Text = Convert.ToString(FilmFilterForm.filmFiltreDTONesne.Point);
            lblTur.Text = FilmFilterForm.filmFiltreDTONesne.Category;
            lblUlke.Text = _filmService.GetByIdFilmService(FilmFilterForm.filmFiltreDTONesne.FilmID).Country.ToList().FirstOrDefault().CountryName;
            lblDil.Text = _filmService.GetByIdFilmService(FilmFilterForm.filmFiltreDTONesne.FilmID).Language.LanguageName;
            lblFilmOzet.Text = _filmService.GetByIdFilmService(FilmFilterForm.filmFiltreDTONesne.FilmID).FilmSummary;
            lblVizyonTarihi.Text = Convert.ToString(_filmService.GetByIdFilmService(FilmFilterForm.filmFiltreDTONesne.FilmID).ReleaseDate);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _ratingService.FilmRatingRatingService(FilmFilterForm.filmFiltreDTONesne.FilmID);

        }
        public byte pointControl()
        {
            if (rdb1.Checked)  //1 point
            {
                return 1;
            }
            else if (rdb2.Checked)//2 point
            {
                return 2;
            }
            else if (rdb3.Checked)//3 point
            {
                return 3;
            }
            else if (rdb4.Checked)//4 point
            {
                return 4;
            }
            else  //5 point
            {
                return 5;
            }
        }

        private void lnkYorumSil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                _ratingService.DeleteRatingService(_rating);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _ratingService.FilmRatingRatingService(FilmFilterForm.filmFiltreDTONesne.FilmID);
            }
            catch (Exception)
            {
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                _userName = dataGridView1.SelectedRows[0].Cells["KullanıcıAdı"].Value.ToString();
            }
            _rating = _ratingService.GetByIDRatingService(LoginForm._userID)
                .Where(x => x.User.UserName == _userName)
                .FirstOrDefault();
        }

        private void txtYorum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtYorum.Text))
                {
                    try
                    {
                        Rating rating = new Rating();
                        rating.Comment = txtYorum.Text;
                        rating.Point = pointControl();
                        rating.CreateDate = DateTime.Now;
                        rating.FilmID = FilmFilterForm.filmFiltreDTONesne.FilmID;
                        rating.UserID = LoginForm._userID;

                        _ratingService.AddRatingService(rating);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = _ratingService.FilmRatingRatingService(FilmFilterForm.filmFiltreDTONesne.FilmID);
                        txtYorum.Clear();
                    }
                    catch (Exception)
                    {
                    }
                   
                }
                else
                {
                    
                    MessageBox.Show("Lütfen Birşeyler Yaz!");
                    txtYorum.Clear();
                }
            }
        }
    }
}
