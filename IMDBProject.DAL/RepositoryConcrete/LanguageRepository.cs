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
    public class LanguageRepository : ILanguageRepository
    {
        int _etkilenenSatir;
        IMDBContext _db = DbInstance.Instance;
        public LanguageRepository()
        {
        }
        public int AddItem(Language item)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                _db.Language.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }

        }

        public int DeleteItem(Language item)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                _db.Language.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }

        }

        public ICollection<Language> GetAll()
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                return _db.Language.ToList();
            }
        }

        public Language GetById(int id)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                return _db.Language.Where(x => x.LanguageID == id).FirstOrDefault();
            }
        }

        public int UpdateItem(Language item)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                Language lastLanguage = _db.Language.Where(x => x.LanguageID == item.LanguageID).FirstOrDefault();
                lastLanguage.LanguageName = item.LanguageName;
                lastLanguage.UpdateDate = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
    }
}
