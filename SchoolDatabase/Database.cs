using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase
{
    class SchoolData
    {
        List<Staff> staffList = new List<Staff>();
        List<Student> studentList = new List<Student>();
        List<SixthFormStudent> sixthFormList = new List<SixthFormStudent>();
        public void AddStaff(Staff s)
        {
            staffList.Add(s);
        }
        public void AddStudent(Student s)
        {
            studentList.Add(s);
        }
        public void AddSixthForm(SixthFormStudent s)
        {
            sixthFormList.Add(s);
        }
        public void DisplayStaff()
        {
            int i = 0;
            foreach (var item in staffList)
            {
                Console.WriteLine("Staff ID: {0}, Name: {1}, Index: {2}", item.id, item.name, i);
                i++;
            }
        }
        public void DisplayStudents()
        {
            int i = 0;
            foreach (var item in studentList)
            {
                Console.WriteLine("Student ID: {0}, Name: {1}, Index: {2}", item.id, item.name, i);
                i++;
            }
        }
        public void DisplaySixthFormStudents()
        {
            int i = 0;
            foreach (var item in sixthFormList)
            {
                Console.WriteLine("Sixth Form Student ID: {0}, Name: {1}, Index: {2}", item.id, item.name, i);
                i++;
            }
        }
        public void RemoveStaff()
        {
            bool valid = false;
            int index = 0;
            while(valid == false)
            {
                Console.WriteLine("Please enter the index of the user you'd like to remove: ");
                string input = Console.ReadLine();
                valid = int.TryParse(input, out index);
                if (index > staffList.Count)
                {
                    valid = false;
                    Console.WriteLine("Invalid index.");
                }
            }
            if(valid)
            {
                staffList.RemoveAt(index);
            }
        }
        public void RemoveStudent()
        {
            bool valid = false;
            int index = 0;
            while (valid == false)
            {
                Console.WriteLine("Please enter the index of the user you'd like to remove: ");
                string input = Console.ReadLine();
                valid = int.TryParse(input, out index);
                if (index > studentList.Count)
                {
                    valid = false;
                    Console.WriteLine("Invalid index.");
                }
            }
            if (valid)
            {
                studentList.RemoveAt(index);
            }
        }
        public void RemoveSixthForm()
        {
            bool valid = false;
            int index = 0;
            while (valid == false)
            {
                Console.WriteLine("Please enter the index of the user you'd like to remove: ");
                string input = Console.ReadLine();
                valid = int.TryParse(input, out index);
                if (index > sixthFormList.Count)
                {
                    valid = false;
                    Console.WriteLine("Invalid index.");
                }
            }
            if (valid)
            {
                sixthFormList.RemoveAt(index);
            }
        }
        public void GetInformation()
        {
            int choice;
            Console.WriteLine("Which database would you like to access? \n" +
                "Input: \n" +
                "\"1\" for Staff. \n" +
                "\"2\" for Students. \n" +
                "\"3\" for Sixth Form Students.");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Which index int the staff database would you like to access? 0 to {0}", (staffList.Count-1));
                    choice = InputHandler(staffList.Count - 1);
                    staffList[choice].GetInfo();
                    break;
                case "2":
                    Console.WriteLine("Which index int the student database would you like to access? 0 to {0}", (studentList.Count - 1));
                    choice = InputHandler(studentList.Count - 1);
                    studentList[choice].GetInfo();
                    break;
                case "3":
                    Console.WriteLine("Which index int the sixth form database would you like to access? 0 to {0}", (sixthFormList.Count - 1));
                    choice = InputHandler(sixthFormList.Count - 1);
                    sixthFormList[choice].GetInfo();
                    break;
                default:
                    Console.WriteLine("Invalid input: enter 1, 2 or 3");
                    break;
            }
        }
        int InputHandler(int max)
        {
            bool valid = false;
            string input;
            int output;
            while (valid == false)
            {
                input = Console.ReadLine();
                valid = int.TryParse(input, out output);
                if (valid)
                {
                    return output;
                } else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
            return 0;
        }
    }
}
