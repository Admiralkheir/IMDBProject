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
    public  class RatingServices
    {
        RatingRepository ratingRepository;
         
        public RatingServices()
        {
            ratingRepository = new RatingRepository();
        }

        public int AddRatingService(Rating rating)
        {
            try
            {
                return ratingRepository.AddItem(rating);
            }
            catch (Exception e)
            {
                MessageBox.Show("Bir Kullanici Sadece Bir Kez Yorum Yapabilir!",e.Message);
                return 0;
            }
        }
        public int UpdateRatingService(Rating rating)
        {
            try
            {
                return ratingRepository.UpdateItem(rating);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata: " + e.Message);
                return 0;
            }
        }
        public int DeleteRatingService(Rating rating)
        {
            try
            {
                return ratingRepository.DeleteItem(rating);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata: " + e.Message);
                return 0;
            }
        }
        public ICollection<Rating> GetByIDRatingService(int id)
        {
            return ratingRepository.GetRatingByID(id);
        }
        public ICollection<Rating> GetAllRatingService()
        {
            return ratingRepository.GetAll();
        }
        public ICollection<FilmRatingDTO> FilmRatingRatingService(int id)
        {
            return ratingRepository.FilmRating(id);
        }

    }



}

