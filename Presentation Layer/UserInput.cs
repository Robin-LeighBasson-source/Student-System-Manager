using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Student_System_Manager.Presentation_Layer
{
    internal class UserInput
    {
        //Fields
        string name;
        string studentID;
        int age;
        string course;

        
        //Encapsulation
        public string Name { get => name; set => name = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public int Age { get => age; set => age = value; }
        public string Course { get => course; set => course = value; }

        //Paramaterised Constructor
        public UserInput(string name, string studentID, int age, string course)
        {
            this.name = name;
            this.studentID = studentID;
            this.age = age;
            this.course = course;
        }

        //Paramaterless Constructor
        public UserInput() { }
    }
}
