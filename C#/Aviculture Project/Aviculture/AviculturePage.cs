using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aviculture
{
    public partial class AviculturePage : Form
    {
        public AviculturePage()
        {
            InitializeComponent();
        }

        DataClassesDataContext db;

        private void AddHen_Click(object sender, EventArgs e)
        {
            db.Add_Hen(Convert.ToInt16(Age.Text), Convert.ToInt16(Type.Text), Convert.ToInt16(Type.Text));
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            db.Delete_Hen(Convert.ToInt16(Age.Text), Convert.ToInt16(Type.Text), Convert.ToInt16(Type.Text));

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            db.Update_Hen(Convert.ToInt16(Age.Text), Convert.ToInt16(Type.Text), Convert.ToInt16(Type.Text));
        }
    }
}
