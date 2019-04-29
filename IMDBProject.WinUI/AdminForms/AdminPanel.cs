using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBProject.WinUI.AdminForms
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.ChildForm(new ActorDirectorForm());
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.ChildForm(new AdminFilm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm.ChildForm(new Language_Category_AddForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm.ChildForm(new CountryCRUDForm());
        }
    }
}
