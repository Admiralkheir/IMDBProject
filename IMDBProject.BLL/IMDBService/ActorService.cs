using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMDBProject.DAL.RepositoryConcrete;
using IMDBProject.Entities.Models;
using IMDBProject.Entities.DTO;
namespace IMDBProject.BLL.IMDBService
{
    public class ActorService
    {
        ActorRepository _actorRepository;
        public ActorService()
        {
            _actorRepository = new ActorRepository();
        }
        public int AddActorService(Actor actor)
        {
            try
            {
                return _actorRepository.AddItem(actor);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata:{0}", e.Message);
                return 0;
            }
        }
        public int DeleteActorService(Actor actor)
        {
            try
            {
                return _actorRepository.DeleteItem(actor);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata:{0}", e.Message);
                return 0; ;
            }
        }

        public List<Actor> GetAllActorService()
        {

            return _actorRepository.GetAll().ToList();

        }

        public int UpdateActorService(Actor actor)
        {
            return _actorRepository.UpdateItem(actor);
        }

        public Actor GetByIDActorService(int id)
        {
            return _actorRepository.GetById(id);
        }
        public List<DirectorRatingDTO> ActorTopFiveFilm(Actor actor)
        {
            return _actorRepository.ActorTopFiveFilm(actor).ToList();
        }
    }
}
