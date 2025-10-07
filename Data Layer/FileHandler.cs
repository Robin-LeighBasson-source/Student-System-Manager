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
    internal class FileHandler
    {
        public FileHandler() { }

        private string filepath = "students.txt";

        public void AddStudent(string studentId, string name, string surname ,int age, string course)
        {
            //Simple text writing
            using (StreamWriter writer = new StreamWriter(filepath, true))
            {
                writer.WriteLine($"{studentId},{name},{surname},{age},{course}");
            }
        }

        public List<UserInput> ViewAll()
        {
            List<UserInput> Students = new List<UserInput>();
            if (File.Exists(filepath))
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string txt;
                    while ((txt = reader.ReadLine()) != null)
                    {
                        string[] parts = txt.Split(',');
                        if (parts.Length == 5)
                        {
                            string studentID = parts[0];
                            string name = parts[1];
                            string surname = parts[2];
                            int age = int.Parse(parts[3]);
                            string courseID = parts[4];
                            Students.Add(new UserInput(studentID, name, surname ,age, courseID));
                        }

                    }
                }
            }            
            return Students;

            
            
        }

    }   
}

