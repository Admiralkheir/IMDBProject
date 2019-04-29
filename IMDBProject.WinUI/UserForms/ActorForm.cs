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
using IMDBProject.Entities.DTO;
namespace IMDBProject.WinUI.UserForms
{
    public partial class ActorForm : Form
    {
        ActorService _actorService;
        FilmServices _filmService;
        public ActorForm()
        {
            InitializeComponent();
            _actorService = new ActorService();
            _filmService = new FilmServices();
            List<DirectorRatingDTO> AktorFilm = _actorService.ActorTopFiveFilm(_actorService.GetByIDActorService(FilmForm._idAktor));
            lblOyuncuAdi.Text = _actorService.GetByIDActorService(FilmForm._idAktor).ActorName;
            lblActorBio.Text = _actorService.GetByIDActorService(FilmForm._idAktor).ActorBiography;
            lblDogumTarihi.Text = Convert.ToString(_actorService.GetByIDActorService(FilmForm._idAktor).BirthDate);
            lblUlke.Text = _actorService.GetByIDActorService(FilmForm._idAktor).Country.CountryName;
            pcbOyuncuResim.ImageLocation = Application.StartupPath + _actorService.GetByIDActorService(FilmForm._idAktor).ActorPhotoUrl;
            try
            {
                pcbPopFilm1.ImageLocation = Application.StartupPath + _filmService.GetByIdFilmService(AktorFilm[0].FilmID).PosterUrl;
                pcbPopFilm2.ImageLocation = Application.StartupPath + _filmService.GetByIdFilmService(AktorFilm[1].FilmID).PosterUrl;
                pcbPopFilm3.ImageLocation = Application.StartupPath + _filmService.GetByIdFilmService(AktorFilm[2].FilmID).PosterUrl;
                pcbPopFilm4.ImageLocation = Application.StartupPath + _filmService.GetByIdFilmService(AktorFilm[3].FilmID).PosterUrl;
                pcbPopFilm5.ImageLocation = Application.StartupPath + _filmService.GetByIdFilmService(AktorFilm[4].FilmID).PosterUrl;
            }
            catch (Exception)
            {


            }
        }

        private void ActorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
