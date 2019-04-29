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
    public partial class CountryCRUDForm : Form
    {
        Country _country;
        CountryService _countryService;
        public CountryCRUDForm()
        {
            InitializeComponent();
            _countryService = new CountryService();
        }

        private void CountryCRUDForm_Load(object sender, EventArgs e)
        {
            cmbGuncellenecekUlke.DisplayMember = "CountryName";
            cmbGuncellenecekUlke.ValueMember = "CountryID";
            cmbGuncellenecekUlke.DataSource = _countryService.GetAllCountriesService();
        }
        private void btnUlkeEkle_Click(object sender, EventArgs e)
        {

            if (_countryService.GetAllCountriesService()
                .Where(x => x.CountryName == txtUlkeEkle.Text)
                .FirstOrDefault() == null)
            {
                errorProvider1.Clear();

                Country country = new Country();
                country.CountryName = txtUlkeEkle.Text;
                country.CreateDate = DateTime.Now;
                int durum = _countryService.AddCountryService(country);
                if (durum > 0)
                {
                    MessageBox.Show("Ülke başarıyla eklendi");
                    cmbGuncellenecekUlke.DisplayMember = "CountryName";
                    cmbGuncellenecekUlke.ValueMember = "CountryID";
                    cmbGuncellenecekUlke.DataSource = _countryService.GetAllCountriesService();
                }
                else
                {
                    MessageBox.Show("Eklenemedi");
                }
            }
            else
            {
                errorProvider1.SetError(txtUlkeEkle, "Bu isimde ülke zaten mevcuttur!");
                return;
            }
            txtUlkeEkle.Clear();

        }

        private void btnUlkGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbGuncellenecekUlke.SelectedValue);
            

            if (_countryService.GetAllCountriesService()
                .Where(x => x.CountryName == txtUlkeGuncelle.Text)
                .FirstOrDefault() == null)
            {
                _country = _countryService.GetByIdCountryService(id);
                _country.CountryName = txtUlkeGuncelle.Text;
                int durum = _countryService.UpdateCountryService(_country);
                if (durum > 0)
                {
                    MessageBox.Show("Ülke başarıyla güncellendi");
                    cmbGuncellenecekUlke.DisplayMember = "CountryName";
                    cmbGuncellenecekUlke.ValueMember = "CountryID";
                    cmbGuncellenecekUlke.DataSource = _countryService.GetAllCountriesService();

                }
                else
                {
                    MessageBox.Show("Güncellenemedi");
                }
            }
            else
            {
                errorProvider1.SetError(txtUlkeGuncelle, "Bu isimde ülke zaten mevcuttur!");
                return;
            }
            txtUlkeGuncelle.Clear();
        }
    }
}
