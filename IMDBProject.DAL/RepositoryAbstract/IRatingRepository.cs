using IMDBProject.Entities.DTO;
using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.DAL.RepositoryAbstract
{
    interface IRatingRepository : IBaseRepository<Rating>
    {
        ICollection<FilmRatingDTO> FilmRating(int id);
        ICollection<Rating> GetRatingByID(int id);
    }
}
