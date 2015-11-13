using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class University
    {
        private string _name;

        private string enrolledStudent;
        private string enrolledPaper;

        public University() //constructor
        {
            _name = "Massey University";
        }

        public string Name
        {
            get { return _name; }
        }
    }
}