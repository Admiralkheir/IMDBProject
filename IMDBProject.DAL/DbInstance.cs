using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMDBProject.DAL.IMDBContextFile;
namespace IMDBProject.DAL
{
    public class DbInstance
    {
        private static IMDBContext _instance;
        public static IMDBContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new IMDBContext();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }
    }
}
