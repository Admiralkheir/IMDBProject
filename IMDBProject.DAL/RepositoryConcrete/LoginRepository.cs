using IMDBProject.DAL.IMDBContextFile;
using IMDBProject.DAL.RepositoryAbstract;
using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.DAL.RepositoryConcrete
{
    public class LoginRepository : ILoginRepository
    {
        IMDBContext _db = DbInstance.Instance;
        public int AddItem(Login item)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                _db.Login.Add(item);
                return _db.SaveChanges();
            //}
        }
        public int DeleteItem(Login item)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                _db.Login.Remove(item);
                return _db.SaveChanges();
            //}
        }
        public ICollection<Login> GetAll()
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                return _db.Login.ToList();
            //}
        }
        public Login GetById(int id)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                return _db.Login.Where(x => x.UserID == id).FirstOrDefault();
            //}
        }
        public bool UserLoginControl(string kullaniciAdi, string sifre)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                User user = _db.User.Where(x => x.UserName == kullaniciAdi && x.Login.Where(log => log.IsActive == true).FirstOrDefault().Password == sifre).FirstOrDefault();

                if (user != null)
                {
                    return true;
                }
                return false;
            //}
        }
        
        public int UpdateItem(Login item)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                Login oldLogin = _db.Login.Where(x => x.UserID == item.UserID).FirstOrDefault();
                oldLogin.IsActive = false;
                oldLogin.UpdateDate = DateTime.Now;
                return _db.SaveChanges();
            //}
        }


    }
}
