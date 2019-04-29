using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.DAL.RepositoryAbstract
{
    interface ILoginRepository : IBaseRepository<Login>
    {
        bool UserLoginControl(string kullaniciAdi, string sifre);       
    }
}
