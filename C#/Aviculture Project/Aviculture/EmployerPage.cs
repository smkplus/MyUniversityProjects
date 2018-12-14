using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aviculture
{
    public partial class EmployerPage : Form
    {
        public EmployerPage()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            db.Add_Employer(UserName.Text, UserLastName.Text, Password.Text, Convert.ToInt32(Age.Text), Convert.ToInt32(Telephone.Text), Address.Text, Convert.ToInt32(ID.Text));
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            datagridview.DataSource = db.SearchName(UserNameSearch.Text);
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            db.ChangePassWord(NewPass.Text, UserNameSearch.Text);
        }
    }
}
