using IMDBProject.DAL.RepositoryConcrete;
using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBProject.BLL.IMDBService
{
    public class CountryService
    {

        CountryRepository _countryRepository;
        public CountryService()
        {
            _countryRepository = new CountryRepository();
        }

        public int AddCountryService(Country country)
        {
            try
            {
                return _countryRepository.AddItem(country);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }

        public int DeleteCountryService(Country country)
        {
            try
            {
                return _countryRepository.DeleteItem(country);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }

        public List<Country> GetAllCountriesService()
        {
            return _countryRepository.GetAll().ToList();
        }

        public Country GetByIdCountryService(int id)
        {
            return _countryRepository.GetById(id);
        }

        public int UpdateCountryService(Country country)
        {
            return _countryRepository.UpdateItem(country);
        }
    }
}
