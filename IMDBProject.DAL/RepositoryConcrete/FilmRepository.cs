using IMDBProject.DAL.IMDBContextFile;
using IMDBProject.DAL.RepositoryAbstract;
using IMDBProject.Entities.DTO;
using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.DAL.RepositoryConcrete
{
    public class FilmRepository : IFilmRepository
    {
        IMDBContext _db = DbInstance.Instance;
        int _affectedrow;
        public int AddItem(Film item)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                _db.Film.Add(item);

                _affectedrow = _db.SaveChanges();

                return _affectedrow;


            }
        }

        public int DeleteItem(Film item)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                _db.Film.Remove(item);

                _affectedrow = _db.SaveChanges();

                return _affectedrow;


            }

        }



        public ICollection<Film> GetAll()
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                return _db.Film.ToList();
            }
        }

        public Film GetById(int id)
        {

            return _db.Film.Where(x => x.FilmID == id).FirstOrDefault();

        }

        public int UpdateItem(Film item)
        {

            Film oldFilm = _db.Film.Where(x => x.FilmID == item.FilmID).FirstOrDefault();
            oldFilm.FilmName = item.FilmName;
            oldFilm.FilmSummary = item.FilmSummary;
            oldFilm.LanguageID = item.LanguageID;
            oldFilm.Country = item.Country;
            oldFilm.Director = item.Director;
            oldFilm.Rating = item.Rating;
            oldFilm.Actor = item.Actor;
            oldFilm.Category = item.Category;
            oldFilm.PosterUrl = item.PosterUrl;
            oldFilm.UpdateDate = DateTime.Now;
            _affectedrow = _db.SaveChanges();

            return _affectedrow;

        }



        public ICollection<Actor> GetFilmActor(int id)
        {
            //using (IMDBContext _db = new IMDBContext())
            {

                return _db.Film.Where(x => x.FilmID == id).FirstOrDefault().Actor;


            }
        }
        public ICollection<Director> GetFilmDirector(int id)
        {
            //using (IMDBContext _db = new IMDBContext())
            {

                return _db.Film.Where(x => x.FilmID == id).FirstOrDefault().Director;


            }
        }

        public List<FilmFiltreDTO> GetFilmRating(string isim)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                if (isim == null)
                {
                    List<FilmFiltreDTO> tablo = (from film in _db.Film
                                                 join rating in _db.Rating on film.FilmID equals rating.FilmID
                                                 group rating by rating.Film.FilmName into filmGrup
                                                 select new FilmFiltreDTO
                                                 {
                                                     FilmID = filmGrup.FirstOrDefault().FilmID,
                                                     FilmName = filmGrup.Key,
                                                     Point = filmGrup.Average(x => x.Point),
                                                     Category = filmGrup.FirstOrDefault().Film.Category.FirstOrDefault().CategoryName

                                                 }).ToList();

                    return tablo;
                }
                else
                {
                    List<FilmFiltreDTO> tablo = (from film in _db.Film
                                                 join rating in _db.Rating on film.FilmID equals rating.FilmID
                                                 group rating by rating.Film.FilmName into filmGrup
                                                 select new FilmFiltreDTO
                                                 {
                                                     FilmID = filmGrup.FirstOrDefault().FilmID,
                                                     FilmName = filmGrup.Key,
                                                     Point = filmGrup.Average(x => x.Point),
                                                     Category = filmGrup.FirstOrDefault().Film.Category.FirstOrDefault().CategoryName
                                                 }).Where(x => x.FilmName.Contains(isim)).ToList();

                    return tablo;
                }

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
    }
}
