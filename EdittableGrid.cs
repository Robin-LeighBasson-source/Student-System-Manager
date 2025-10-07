using Student_System_Manager.Data_Layer;
using Student_System_Manager.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_System_Manager
{
    public partial class EdittableGrid : Form
    {
        public EdittableGrid()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmHomeScreen frmHomeScreen = new frmHomeScreen();
            this.Hide();
            frmHomeScreen.Show();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            FileHandler handler = new FileHandler();
            List<UserInput> Students = handler.ViewAll();
            dgvStudents.DataSource = Students;
        }


    }
}
