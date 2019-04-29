using IMDBProject.WinUI.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBProject.WinUI
{
    public partial class MainForm : Form
    {
        public static MainForm _instance;
        public static void ChildForm(Form _childForm)
        {
            Instance.Show();
          
            bool Durum = false;
            foreach (Form item in _instance.MdiChildren)
            {
                if (item.Text == _childForm.Text)
                {
                    Durum = true;
                    item.Activate();
                }
                else
                {
                    item.Hide();
                }
            }
            if (Durum == false)
            {
                _childForm.MdiParent = _instance;//bu sayede mdi'ın içinde gösterdi.
                _childForm.Show();
            }
        }
        public static MainForm Instance
        {
            get { return _instance ?? (_instance = new MainForm()); }
        }
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
