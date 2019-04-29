using IMDBProject.BLL.IMDBService;
using IMDBProject.Entities.Models;
using IMDBProject.WinUI.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBProject.WinUI.UserForms
{
    public partial class LoginForm : Form
    {
        LoginService _loginService;
        UserService _userService;
        public static short _userID = 0;
        User _user;
        public LoginForm()
        {
            InitializeComponent();
            _loginService = new LoginService();
            _userService = new UserService();
        }
        private void btnLoginGiris_Click(object sender, EventArgs e)
        {
            if (_loginService.UserLoginControlService(txtKullaniciAdi.Text, txtKullaniciSifre.Text))
            {
                _userID = _userService.GetCurrentUserID(txtKullaniciAdi.Text, txtKullaniciSifre.Text);
                _user = _userService.GetByIDLoginService(_userID);
                if (_user.IsAdmin)
                {
                    MainForm.ChildForm(new AdminPanel());

                }
                else
                {
                    MainForm.ChildForm(new FilmFilterForm());
                }
            }
            else
            {
                MessageBox.Show("Giriş Başarısız. Kulanıcı Adı ve Şifrenizi Kontrol Ediniz");
            }
        }

        private void linkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.ChildForm(new KaydolForm());
        }

        private void linkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.ChildForm(new SifremiUnuttumForm());
        }


      
    }
}
