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
    public class RatingRepository : IRatingRepository
    {
        IMDBContext _db = DbInstance.Instance;
        int _affectedrow;
        public int AddItem(Rating item)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                _db.Rating.Add(item);

                _affectedrow = _db.SaveChanges();

                return _affectedrow;


            //}
        }

        public int DeleteItem(Rating item)
        {
            
                _db.Rating.Remove(item);

                _affectedrow = _db.SaveChanges();

                return _affectedrow;



        }

        public ICollection<Rating> GetAll()
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                return _db.Rating.ToList();
            //}
        }

        public ICollection<Rating> GetRatingByID(int id)
        {
            
            return _db.Rating.Where(x => x.UserID == id).ToList();
        }

        public int UpdateItem(Rating item)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                Rating oldRating = new Rating();
                oldRating = _db.Rating.Where(x => x.FilmID == item.FilmID && x.UserID == item.UserID).FirstOrDefault();
                oldRating.Comment = item.Comment;
                oldRating.Point = item.Point;
                oldRating.UpdateDate = DateTime.Now;

                _affectedrow = _db.SaveChanges();

                return _affectedrow = _db.SaveChanges();

            //}

        }

        public ICollection<FilmRatingDTO> FilmRating(int id)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                return (from rating in _db.Rating
                        join user in _db.User on rating.UserID equals user.UserID
                        where rating.FilmID == id
                        select new FilmRatingDTO
                        {
                            KullanıcıAdı = user.UserName,
                            Puan = rating.Point,
                            Yorum = rating.Comment

                        }).ToList();


            //}
        }

        public Rating GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
