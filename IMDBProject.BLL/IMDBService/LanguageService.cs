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
    public class LanguageService
    {
        LanguageRepository _languageRepository;
        public LanguageService()
        {
            _languageRepository = new LanguageRepository();
        }
        public int AddLanguageService(Language language)
        {
            try
            {
                return _languageRepository.AddItem(language);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata: "+e.Message);
                return 0;
            }
        }
        public int DeleteLanguageService(Language language)
        {
            try
            {
                return _languageRepository.DeleteItem(language);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata: " + e.Message);
                return 0;
            }
        }

        public List<Language> GetAllLanguagesService()
        {
            return _languageRepository.GetAll().ToList();
        }
        
        public Language GetByIdLanguageService(int id)
        {
            return _languageRepository.GetById(id);
        }

        public int UpdateLanguageService(Language language)
        {
            return _languageRepository.UpdateItem(language);
        }
    }
}
