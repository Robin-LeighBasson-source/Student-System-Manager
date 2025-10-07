using Student_System_Manager.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Student_System_Manager.Data_Layer
{
    public class FileHandler
    {
        public FileHandler() { }

        private string filepath = "students.txt";

        public void Student(string studentId, string name, int age, string course)
        {
            //Simple text writing
            using (StreamWriter writer = new StreamWriter(filepath, true))
            {
                writer.WriteLine($"{studentId},{name},{age},{course}");
            }
        }


       




    }   
}

