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
namespace IMDBProject.WinUI.AdminForms
{
    public partial class ActorDirectorForm : Form
    {
        ActorService _actorService;
        CountryService _countryService;
        DirectorService _directorService;
        string path;
        public ActorDirectorForm()
        {
            InitializeComponent();
            _actorService = new ActorService();
            _countryService = new CountryService();
            _directorService = new DirectorService();
            cbxOyuncuUlke.DisplayMember = "CountryName";
            cbxOyuncuUlke.ValueMember = "CountryID";
            cbxOyuncuUlke.DataSource = _countryService.GetAllCountriesService();

            cbxYonetmenUlke.DisplayMember = "CountryName";
            cbxYonetmenUlke.ValueMember = "CountryID";
            cbxYonetmenUlke.DataSource = _countryService.GetAllCountriesService();
        }

        private void btnOyuncuKaydet_Click(object sender, EventArgs e)
        {
            Actor yeniAktor = new Actor();
            yeniAktor.ActorName = txtOyuncuAd.Text;
            yeniAktor.ActorSurname = txtOyuncuSoyad.Text;
            yeniAktor.ActorPhotoUrl = path;
            yeniAktor.BirthDate = dtpOyuncuDogumTarihi.Value;
            yeniAktor.CreateDate = DateTime.Now;
            if (rdbOyuncuErkek.Checked==true)
            {
                yeniAktor.ActorGender = true;
            }
            else if (rdbOyuncuKadin.Checked == true)
            {
                yeniAktor.ActorGender = false;
            }
            yeniAktor.ActorBiography = txtOyuncuBiyografi.Text;
            yeniAktor.CountryID = Convert.ToInt16(cbxOyuncuUlke.SelectedValue);
            if (_actorService.AddActorService(yeniAktor)>0)
            {
                MessageBox.Show(yeniAktor.ActorName +" "+ yeniAktor.ActorSurname +" Eklendi");
            }
            else
            {
                MessageBox.Show("Hata. Eklenemdi");
            }
                       
        }

        private void btnYonetmenKaydet_Click(object sender, EventArgs e)
        {
            Director yeniYonetmen = new Director();
            yeniYonetmen.DirectorName = txtYonetmenAd.Text;
            yeniYonetmen.DirectorSurname = txtYonetmenSoyad.Text;
            yeniYonetmen.PhotoUrl = path;
            yeniYonetmen.BirthDate = dtpYonetmenDogumTarih.Value;
            yeniYonetmen.CreateDate = DateTime.Now;
            if (rdbYonetmenErkek.Checked == true)
            {
                yeniYonetmen.Gender = true;
            }
            else if (rdbYonetmenKadin.Checked == true)
            {
                yeniYonetmen.Gender = false;
            }
            yeniYonetmen.DirectorBiography = txtYonetmenBiyografi.Text;
            yeniYonetmen.CountryID = Convert.ToInt16(cbxYonetmenUlke.SelectedValue);
            if (_directorService.AddDirectorService(yeniYonetmen)>0)
            {
                MessageBox.Show(yeniYonetmen.DirectorName + " " + yeniYonetmen.DirectorSurname + " Eklendi");
            }
            else
            {
                MessageBox.Show("Eklenemedi");
            }

        }

        private void btnOyuncuResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string url = openFileDialog1.SafeFileName;
            path = "\\Images\\ActorImages\\" + url;
            //string path = Application.StartupPath + yeniURL;

        }

        private void btnYonetmenResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string url = openFileDialog1.SafeFileName;
            path = "\\Images\\DirectorImages\\" + url;
            //string path = Application.StartupPath + yeniURL;
        }
    }
}
