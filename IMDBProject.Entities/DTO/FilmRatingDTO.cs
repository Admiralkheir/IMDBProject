using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.Entities.DTO
{
    public class FilmRatingDTO
    {
        public string KullanıcıAdı { get; set; } 
        public byte Puan { get; set; }
        public string Yorum { get; set; }

    }
}
