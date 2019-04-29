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
    public class LoginService
    {
        LoginRepository _loginRepository;
        public LoginService()
        {
            _loginRepository = new LoginRepository();
        }
        public int AddLoginService(Login login)
        {
            try
            {
                return _loginRepository.AddItem(login);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }

        public int DeleteLoginService(Login login)
        {
            try
            {
                return _loginRepository.DeleteItem(login);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public int UpdateLoginService(Login login)
        {
            try
            {
                return _loginRepository.UpdateItem(login);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public bool UserLoginControlService(string kullaniciAdi, string sifre)
        {
            return _loginRepository.UserLoginControl(kullaniciAdi, sifre);
        }
        
        //This method is not an interface property. 
        public string AdminOrUser(User user)
        {
            if (user.IsAdmin)
            {
                return "admin";
            }
            else
            {
                return "user";
            }
        }
        public List<Login> GetAllLoginService()
        {
            return _loginRepository.GetAll().ToList();
        }

        public Login GetByIDLoginService(int id)
        {
            return _loginRepository.GetById(id);
        }
    }
}
