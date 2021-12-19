using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Class1
    {
        private int role;
        private string name;
        private string fathername;
        public int Role { 
            get { return role; } 
            set { role = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Fathername
        {
            get { return fathername; }
            set { fathername = value; }
        }
    }
}
