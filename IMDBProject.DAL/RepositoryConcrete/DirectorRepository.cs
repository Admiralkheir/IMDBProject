using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMDBProject.DAL.RepositoryAbstract;
using IMDBProject.Entities.Models;
using IMDBProject.DAL.IMDBContextFile;
using IMDBProject.Entities.DTO;
using System.Linq.Expressions;
namespace IMDBProject.DAL.RepositoryConcrete
{
    public class DirectorRepository : IDirectorRepository
    {
        IMDBContext _db = DbInstance.Instance;
        int _etkilenenSatir;
        public int AddItem(Director item)
        {
            //using (IMDBContext _db= new IMDBContext())
            {
                _db.Director.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(Director item)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                _db.Director.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<DirectorRatingDTO> DirectorTopFiveFilm(Director director)
        {

            List<DirectorRatingDTO> tablo = (from film in _db.Film.ToList().Where(x => x.Director.Contains(director))
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

        public ICollection<Director> GetAll()
        {
            //using (IMDBContext _db=new IMDBContext())
            {
                return _db.Director.ToList();
            }
        }

        public Director GetById(int id)
        {
            return _db.Director.Where(x => x.DirectorID == id).FirstOrDefault();

        }

        public int UpdateItem(Director item)
        {
            //using (IMDBContext _db= new IMDBContext())
            {
                Director eskiDirector = _db.Director.Where(x => x.DirectorID == item.DirectorID).FirstOrDefault();
                eskiDirector.BirthDate = item.BirthDate;
                eskiDirector.Country = item.Country;
                eskiDirector.DirectorBiography = item.DirectorBiography;
                eskiDirector.DirectorName = item.DirectorName;
                eskiDirector.DirectorSurname = item.DirectorSurname;
                eskiDirector.Gender = item.Gender;
                eskiDirector.PhotoUrl = item.PhotoUrl;
                eskiDirector.Film = item.Film;
                eskiDirector.UpdateDate = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }

        }
    }
}
