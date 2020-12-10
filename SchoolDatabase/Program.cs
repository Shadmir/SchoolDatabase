using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Add way of calling getInfo on specific index of list.
            SchoolData People = new SchoolData();
            void Menu()
            {
                Console.WriteLine("Enter a menu option: \n" +
                    "1: Add Staff \n" +
                    "2: Add Student \n" +
                    "3: Add Sixth Form Student \n" +
                    "4: Display All Staff \n" +
                    "5: Display All Students \n" +
                    "6: Display All Sixth Form Students \n" +
                    "7: Remove Staff \n" +
                    "8: Remove Student \n" +
                    "9: Remove Sixth Form Student \n" +
                    "10: Get Information. \n" +
                    "11: Quit.");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Staff staff = new Staff();
                        People.AddStaff(staff);
                        break;
                    case "2":
                        Student student = new Student();
                        People.AddStudent(student);
                        break;
                    case "3":
                        SixthFormStudent sixthForm = new SixthFormStudent();
                        People.AddSixthForm(sixthForm);
                        break;
                    case "4":
                        People.DisplayStaff();
                        break;
                    case "5":
                        People.DisplayStudents();
                        break;
                    case "6":
                        People.DisplaySixthFormStudents();
                        break;
                    case "7":
                        People.RemoveStaff();
                        break;
                    case "8":
                        People.RemoveStudent();
                        break;
                    case "9":
                        People.RemoveSixthForm();
                        break;
                    case "10":
                        People.GetInformation();
                        break;
                    case "11":
                        Console.WriteLine("Press enter to quit.");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
            while (true)
            {
                Console.WriteLine("Press [return] to continue...");
                Console.ReadLine();
                Menu();
            }
        }
    }
}
