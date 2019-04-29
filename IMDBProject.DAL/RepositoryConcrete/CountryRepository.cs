using IMDBProject.DAL.IMDBContextFile;
using IMDBProject.DAL.RepositoryAbstract;
using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.DAL.RepositoryConcrete
{
    public class CountryRepository : ICountryRepository
    {
        IMDBContext _db = DbInstance.Instance;
        int _etkilenenSatir;
        public CountryRepository()
        {

        }
        public int AddItem(Country item)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                _db.Country.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
                
        }

        public int DeleteItem(Country item)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                _db.Country.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<Country> GetAll()
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                return _db.Country.ToList();
            }
        }

        public Country GetById(int id)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                return _db.Country.Where(x => x.CountryID == id).FirstOrDefault();
            }
        }

        public int UpdateItem(Country item)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                Country lastCountry = _db.Country.Where(x => x.CountryID == item.CountryID).FirstOrDefault();
                lastCountry.CountryName = item.CountryName;
                lastCountry.UpdateDate = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
    }
}
