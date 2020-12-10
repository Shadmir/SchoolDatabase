using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase
{
    class Student : Person
    {
        public Student()
        {
            setID();
            networkRights = "Low";
        }
    }   
}
