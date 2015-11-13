using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
   public class EnrollStudents
    {
         private string EnrollStudent;
        private string EnrollPaper;

        public EnrollStudents (string student, string paper)  //constructors
        {
            EnrollStudent = student;
            EnrollPaper = paper;
        }

        public override string ToString() //function to return  the paper name
        {
            return EnrollPaper;
        }

        public string printout () //function to return the student name
        {
            return EnrollStudent;
        }
    }
}
