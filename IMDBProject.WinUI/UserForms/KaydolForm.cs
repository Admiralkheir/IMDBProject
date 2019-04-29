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
    public partial class KaydolForm : Form
    {
        UserService _userService;
        LoginService _loginService;
        int _number;
        int _number2;
        Login _login;
        User _user;
        public KaydolForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _loginService = new LoginService();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                errorKayitForm.SetError(txtAd, "Bu Alan Boş Geçilemez");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                errorKayitForm.SetError(txtSoyad, "Bu Alan Boş Geçilemez");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEposta.Text))
            {
                errorKayitForm.SetError(txtEposta, "Bu Alan Boş Geçilemez");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                errorKayitForm.SetError(txtKullaniciAdi, "Bu Alan Boş Geçilemez");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                errorKayitForm.SetError(txtSifre, "Bu Alan Boş Geçilemez");
                return;
            }
            errorKayitForm.Clear();
            if (DateTime.Today.Year - dtpDogumTarihi.Value.Year < 15)
            {
                MessageBox.Show("15 Yaşından Küçükler Kayıt Olamaz");
                return;
            }
            //daha önce alınan kullanıcı adı kullanılamaz
            if (_userService.GetAllLoginService()
                    .Where(x => x.UserName == txtKullaniciAdi.Text)
                    .FirstOrDefault() != null)
            {
                errorKayitForm.SetError(txtKullaniciAdi, txtKullaniciAdi.Text + " kullanıcı adını başka bir hesap kullanıyor.");
                return;
            }
            //daha önce kayıt olunan eposta ile kayıt olunamaz
            else if (_userService.GetAllLoginService()
                    .Where(x => x.Email == txtEposta.Text)
                    .FirstOrDefault() != null)
            {
                errorKayitForm.SetError(txtEposta, txtEposta.Text + " adresini başka bir hesap kullanıyor.");
                return;
            }
            else
            {
                _user = new User
                {
                    Name = txtAd.Text,
                    Surname = txtSoyad.Text,
                    Email = txtEposta.Text,
                    UserName = txtKullaniciAdi.Text,
                    BirthDate = dtpDogumTarihi.Value,
                    CreateDate = DateTime.Now
                };
                _number = _userService.AddUserService(_user);
            }
            //eğer kullanıcı oluşturulduysa login ekle
            if (_number > 0)
            {
                _login = new Login
                {
                    UserID = _user.UserID,
                    Password = txtSifre.Text,
                    IsActive = true,
                    CreateDate = DateTime.Now
                };
            }
            _number2 = _loginService.AddLoginService(_login);
            //kullanıcı kayıt ve login ekleme başarılı olduysa mesaj göster
            if (_number > 0 && _number2 > 0)
            {
                MessageBox.Show("Kullanici başarıyla eklendi");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Eklenemedi");
            }
        }
    }
}
