using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Student
    {
        private string _name;
        private string _birthdate;
        private string _studentID;
        private string _address;

        public Student(string name, string birthdate, string studentID, string address) //constructor
        {
            _name = name;
            _birthdate = birthdate;
            _studentID = studentID;
            _address = address;
        }

        public override string ToString()
        {
            return _name; //get student name
        }

        public string getId()
        {
            return _studentID; //get student id
        }
    }
}
