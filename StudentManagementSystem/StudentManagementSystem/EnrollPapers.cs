using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class EnrollPapers
    {
        private string EnrollStudent;
        private string EnrollPaper;

        public EnrollPapers (string student, string paper)  //constructor
        {
            EnrollStudent = student;
            EnrollPaper = paper;
        }

        public override string ToString()
        {
            return EnrollStudent; //passing students 
        }

        public string printout()
        {
            return EnrollPaper; //passing papers
        }
    }
}
