using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMDBProject.DAL.RepositoryAbstract;
using IMDBProject.Entities.Models;
using IMDBProject.DAL.IMDBContextFile;
using IMDBProject.Entities.DTO;

namespace IMDBProject.DAL.RepositoryConcrete
{
    public class ActorRepository : IActorRepository
    {
        int _etkilenenSatir;
        IMDBContext _db = DbInstance.Instance;
        
        public ICollection<DirectorRatingDTO> ActorTopFiveFilm(Actor actor)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                List<DirectorRatingDTO> tablo = (from film in _db.Film.ToList().Where(x => x.Actor.Contains(actor))
                                                 join rating in _db.Rating
                       on film.FilmID equals rating.FilmID
                                                 group rating by rating.Film.FilmName into filmGrup
                                                 select new DirectorRatingDTO
                                                 {
                                                     FilmID = filmGrup.FirstOrDefault().FilmID,
                                                     FilmName = filmGrup.Key,
                                                     FilmPuan = filmGrup.Sum(x => x.Point)
                                                 }).OrderByDescending(x => x.FilmPuan).Take(5).ToList();
                return tablo;

                //List<DirectorRatingDTO> tablo2 =
                //_db.Film.GroupJoin(_db.Rating,
                //               x => x.FilmID,
                //               y => y.FilmID,
                //               (x, y) => new DirectorRatingDTO
                //               {
                //                   FilmID=x.FilmID,
                //                   FilmName=x.FilmName,
                //                   FilmPuan=y.Sum(a=>a.Point)
                //               }).OrderByDescending(x=>x.FilmPuan).ToList();
            }
        }

        public int AddItem(Actor item)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                _db.Actor.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(Actor item)
        {
            //using (IMDBContext _db=new IMDBContext())
            {
                _db.Actor.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<Actor> GetAll()
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                return _db.Actor.ToList();
            }
        }

        public Actor GetById(int id)
        {

                return _db.Actor.Where(x => x.ActorID == id).FirstOrDefault();

            
        }

        public int UpdateItem(Actor item)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                Actor eskiActor = _db.Actor.Where(x => x.ActorID == item.ActorID).FirstOrDefault();
                eskiActor.ActorBiography = item.ActorBiography;
                eskiActor.ActorGender = item.ActorGender;
                eskiActor.ActorName = item.ActorName;
                eskiActor.ActorPhotoUrl = item.ActorPhotoUrl;
                eskiActor.ActorSurname = item.ActorSurname;
                eskiActor.BirthDate = item.BirthDate;
                eskiActor.Country = item.Country;
                eskiActor.UpdateDate = DateTime.Now;
                eskiActor.Film = item.Film;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;

            }
        }
    }
}
