using IMDBProject.Entities.DTO;
using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.DAL.RepositoryAbstract
{
    interface IFilmRepository : IBaseRepository<Film>
    {

        List<FilmFiltreDTO> GetFilmRating(string isim);
        ICollection<Actor> GetFilmActor(int id);
        ICollection<Director> GetFilmDirector(int id);
    }
}
