using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase
{
    class Person
    {
        public string networkRights;
        public string name;
        public string DOB;
        public int id;
        public string address;

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: {0}\n" +
                "Date of Birth: {1}\n" +
                "Address: {2}\n" +
                "ID: {3}\n" +
                "Network Rights: {4}", name, DOB, address, id, networkRights);
        }
        public virtual void setID()
        {
            var random = new Random();
            int randInt = random.Next(99999);
            id = 100000 + randInt;
        }
        public Person()
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter date of birth (dd/mm/yyyy): ");
            DOB = Console.ReadLine();
        }
    }
}
