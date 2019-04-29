using IMDBProject.BLL.IMDBService;
using IMDBProject.Entities.Models;
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
    public partial class SifremiUnuttumForm : Form
    {
        UserService _userService;
        LoginService _loginService;
        User _user;
        Login _login;
        public SifremiUnuttumForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _loginService = new LoginService();
            _user = new User();
            _login = new Login();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEposta.Text))
            {
                errorSifreForm.SetError(txtEposta, "Bu Alan Boş Geçilemez");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                errorSifreForm.SetError(txtKullaniciAdi, "Bu Alan Boş Geçilemez");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                errorSifreForm.SetError(txtSifre, "Bu Alan Boş Geçilemez");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSifreTekrar.Text))
            {
                errorSifreForm.SetError(txtSifreTekrar, "Bu Alan Boş Geçilemez");
                return;
            }
            errorSifreForm.Clear();

            if (_userService.PasswordControlService(txtKullaniciAdi.Text, txtEposta.Text))
            {

                _user = _userService.GetAllLoginService()
                    .Where(x => x.UserName == txtKullaniciAdi.Text && x.Email == txtEposta.Text)
                    .FirstOrDefault();

                _login = _loginService.GetAllLoginService()
                    .Where(x => x.UserID == _user.UserID && x.IsActive == true)
                    .FirstOrDefault();

                int sayi = _loginService.UpdateLoginService(_login);

                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    Login login = new Login
                    {
                        Password = txtSifreTekrar.Text,
                        IsActive = true,
                        UserID = _login.UserID,
                        CreateDate = DateTime.Now
                    };
                    int sayi2 = _loginService.AddLoginService(login);
                    if (sayi2 > 0)
                    {
                        MessageBox.Show("Şifreniz Güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Sağlanamadı");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Aynı Olmalı");
                }
            }
            else
            {
                MessageBox.Show("Kontrol Sağlanamadı");
            }
        }
    }
}

