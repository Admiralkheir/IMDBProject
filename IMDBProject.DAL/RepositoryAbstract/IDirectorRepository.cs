using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMDBProject.Entities.DTO;
namespace IMDBProject.DAL.RepositoryAbstract
{
    interface IDirectorRepository:IBaseRepository<Director>
    {
        ICollection<DirectorRatingDTO> DirectorTopFiveFilm(Director director);

    }
}
