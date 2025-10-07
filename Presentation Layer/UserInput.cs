using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_System_Manager.Presentation_Layer
{
    internal class UserInput
    {
        //Fields
        string studentID;
        string name;
        string surname;
        int age;
        string course;

        //Encapsulation
        public string StudentID { get => studentID; set => studentID = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Course { get => course; set => course = value; }
        public string Surname { get => surname; set => surname = value; }

        //Paramaterised Constructor
        public UserInput(string studentID, string name, string surname, int age, string course)
        {
            this.studentID = studentID;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.course = course;
        }

        //Paramaterless Constructor
        public UserInput() { }

        //Methods
        public void CalcAge(DateTime DoB)
        {
            Age = DateTime.Now.Year - DoB.Year;
        }
    }
}
