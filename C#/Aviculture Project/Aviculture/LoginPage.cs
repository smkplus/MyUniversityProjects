using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aviculture
{
    public partial class LoginPage 
        : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            var result = db.IsLogin(UserName.Text, Password.Text);
            if(result == 1)
            {
                Home home = new Home();
                home.Show();
                LoginPage loginpage = new LoginPage();
                this.Hide();
            }
            else
            {
                MessageBox.Show("پسورد اشتباه است");
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            EmployerPage Re = new EmployerPage();
            Re.Show();
        }
    }
}
