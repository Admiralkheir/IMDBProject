using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.Entities.DTO
{
   public  class FilmFiltreDTO
    {
        public short FilmID { get; set; }
        public string FilmName { get; set; }
        public string Category { get; set; }
        public double Point { get; set; }

    }
}
