using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase
{
    class Staff : Person
    {
        public string id;
        string initials;       
        public Staff()
        {
            GetInitials();
            id = "staff" + initials;
            networkRights = "High";
        }
        private void GetInitials()
        {
            initials = "";
            Array nameArray = name.Split(' ');
            foreach (string word in nameArray)
            {
                initials += word[0];
            }
        }
        public override void GetInfo()
        {
            Console.WriteLine("Name: {0}\n" +
                "Date of Birth: {1}\n" +
                "Address: {2}\n" +
                "ID: {3}\n" +
                "Network Rights: {4}", name, DOB, address, id, networkRights);
        }
    }
}
