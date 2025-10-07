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
    public partial class frmHomeScreen : Form
    {
        public frmHomeScreen()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            UserInput userInput = new UserInput();

            if (edtName.Text == "" || edtStudentID.Text == "" || cmbCourse.SelectedIndex == -1 || dtpDoB.Value >= DateTime.Now)
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                userInput.StudentID = edtName.Text;
                userInput.Name = edtName.Text;
                userInput.Course = cmbCourse.SelectedItem.ToString();
                userInput.CalcAge(dtpDoB.Value);
            }

            FileHandler fileHandler = new FileHandler();
            fileHandler.Student(userInput.StudentID,userInput.Name, userInput.Age, userInput.Course);

        }

        private void btnViewAllStudents_Click(object sender, EventArgs e)
        {
            EdittableGrid edittableGrid = new EdittableGrid();

            this.Hide();
            edittableGrid.Show();
            
        }
    }
}
