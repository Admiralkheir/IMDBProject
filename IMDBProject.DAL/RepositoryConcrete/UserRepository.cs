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
    public class UserRepository : IUserRepository
    {
        IMDBContext _db = DbInstance.Instance;
        public int AddItem(User item)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                _db.User.Add(item);
                return _db.SaveChanges();
            //}
        }

        public int DeleteItem(User item)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                _db.User.Remove(item);
                return _db.SaveChanges();
            //}
        }

        public ICollection<User> GetAll()
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                return _db.User.ToList();
            //}
        }

        public User GetById(int id)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
            return _db.User.Where(x => x.UserID == id).FirstOrDefault();
            //}
        }

        public short GetUserID(string kullaniciAdi, string sifre)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                User user = _db.User.Where(x => x.UserName == kullaniciAdi && x.Login.Where(log => log.IsActive == true).FirstOrDefault().Password == sifre).FirstOrDefault();

                return user.UserID;
            //}
        }

        public bool PasswordControl(string kullaniciAdi, string eposta)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                User user = _db.User.Where(x => x.UserName == kullaniciAdi && x.Email == eposta && x.Login.FirstOrDefault().IsActive == true).FirstOrDefault();
                if (user != null)
                {
                    return true;
                }
                return false;
            //}
        }

        public int UpdateItem(User item)
        {
            //using (IMDBContext _db = new IMDBContext())
            //{
                User oldUser = _db.User.Where(x => x.UserID == item.UserID).FirstOrDefault();
                oldUser.Name = item.Name;
                oldUser.Surname = item.Surname;
                oldUser.IsAdmin = item.IsAdmin;
                oldUser.UserName = item.UserName;
                oldUser.Email = item.Email;
                oldUser.BirthDate = item.BirthDate;
                oldUser.UpdateDate = DateTime.Now;
                return _db.SaveChanges();
            //}
        }
    }
}
