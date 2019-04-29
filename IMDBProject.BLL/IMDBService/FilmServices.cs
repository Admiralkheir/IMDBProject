using IMDBProject.DAL.IMDBContextFile;
using IMDBProject.DAL.RepositoryConcrete;
using IMDBProject.Entities.DTO;
using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBProject.BLL.IMDBService
{
   public class FilmServices
    {
        FilmRepository filmRepository;
        public FilmServices()
        {
             filmRepository   = new FilmRepository();
        }
        public int AddFilmService(Film film)
        {
            try
            {
                return filmRepository.AddItem(film);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata: " + e.Message);
                return 0;
            }
        }
        public int UpdateFilmService(Film film)
        {
            try
            {
                return filmRepository.UpdateItem(film);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata: " + e.Message);
                return 0;
            }
        }
        public int DeleteFilmService(Film film)
        {
            try
            {
                return filmRepository.DeleteItem(film);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata: " + e.Message);
                return 0;
            }
        }
        public Film GetByIdFilmService(int id)
        {
            
                return filmRepository.GetById(id);
        

        }
        public ICollection<Film> GetAllFilmService()
        {

            return filmRepository.GetAll();
      
         
        }


       public  ICollection<Actor> GetFilmActorFilmService(int id)
        {
            return filmRepository.GetFilmActor(id);
        }
        public List<FilmFiltreDTO> GetFilmsRating(string isim)
        {
            return filmRepository.GetFilmRating(isim);
        }
        public ICollection<Director> GetFilmDirector(int id)
        {
            return filmRepository.GetFilmDirector(id).ToList();
        }


    }
}
