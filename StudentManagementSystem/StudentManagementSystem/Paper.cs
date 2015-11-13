using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Paper
    {
        private string _name;
        private string _code;
        private string _paperCo;

        public Paper(string name, string code, string paperCo) //constructor
        {
            _name = name;
            _code = code;
            _paperCo = paperCo;
        }

        public override string ToString()
        {
            return _code; //passing paper id
        }
        public string getpapername()
        {
            return _name; //passing paper name
        }
    }
}
