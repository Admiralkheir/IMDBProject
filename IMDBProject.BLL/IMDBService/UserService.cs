using IMDBProject.DAL.RepositoryConcrete;
using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBProject.BLL.IMDBService
{
    public class UserService
    {
        UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public int AddUserService(User user)
        {
            try
            {
                return _userRepository.AddItem(user);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }

        public int DeleteUserService(User user)
        {
            try
            {
                return _userRepository.DeleteItem(user);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public int UpdateUserService(User user)
        {
            try
            {
                return _userRepository.UpdateItem(user);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public bool PasswordControlService(string kullaniciAdi, string eposta)
        {
            return _userRepository.PasswordControl(kullaniciAdi, eposta);
        }
        public short GetCurrentUserID(string kullaniciAdi, string sifre)
        {
            return _userRepository.GetUserID(kullaniciAdi, sifre);
        }

        public List<User> GetAllLoginService()
        {
            return _userRepository.GetAll().ToList();
        }

        public User GetByIDLoginService(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}
