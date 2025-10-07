using System;
using System.Collections.Generic;
using System.Linq;
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

        //
    }
}
