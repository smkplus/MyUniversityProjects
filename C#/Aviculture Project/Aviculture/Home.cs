using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviculture
{
    public partial class Home : Form
    {
        DataClassesDataContext db;
        public Home()
        {
            InitializeComponent();
             db = new DataClassesDataContext();
        }



        private void EmployerPage_Click(object sender, EventArgs e)
        {
            EmployerPage employerPage = new EmployerPage();
            employerPage.ShowDialog();
        }

        private void Aviculture_Click(object sender, EventArgs e)
        {
            AviculturePage aviculturePage = new AviculturePage();
            aviculturePage.Show();
        }
    }
}
