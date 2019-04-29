using IMDBProject.DAL.RepositoryConcrete;
using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMDBProject.Entities.DTO;
namespace IMDBProject.BLL.IMDBService
{
    public class DirectorService
    {
        DirectorRepository _directorRepository;
        public DirectorService()
        {
            _directorRepository = new DirectorRepository();
        }
        public int AddDirectorService(Director director)
        {
            try
            {
                return _directorRepository.AddItem(director);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata:{0}", e.Message);
                return 0;
            }
        }
        public int DeleteDirectorService(Director director)
        {
            try
            {
                return _directorRepository.DeleteItem(director);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata:{0}", e.Message);
                return 0; ;
            }
        }

        public List<Director> GetAllDirectorService()
        {

            return _directorRepository.GetAll().ToList();

        }

        public int UpdateDirectorService(Director director)
        {
            return _directorRepository.UpdateItem(director);
        }

        public Director GetByIdDirectorService(int id)
        {
            return _directorRepository.GetById(id);
        }
        public List<DirectorRatingDTO> GetDirectorTopFive(Director director)
        {
            return _directorRepository.DirectorTopFiveFilm(director).ToList();
        }

    }
}
