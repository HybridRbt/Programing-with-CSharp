using System;

namespace ConsoleApplicationHomeWork4
{
    class Program
    {
        public struct Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDay { get; set; }
        }
        
        public struct Teacher
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }

        public struct DegreeProgram
        {
            public string Name { get; set; }
            public string Length { get; set; }
            public string Credit { get; set; }
        }

        public struct Course
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public string Semester { get; set; }
        }

        static void Main(string[] args)
        {
            Student[] studentsArray = new Student[5];
            
            string firstName = "John";
            string lastName = "Reese";
            DateTime birthday = new DateTime(1983, 3, 15);
            
            AssignStudentDetails(ref studentsArray[0], firstName, lastName, birthday);
            AssignStudentDetails(ref studentsArray[1], "Kyle", "Finch", new DateTime(1973, 5, 21));

            Console.WriteLine("Details about the first student:");
            PrintStudentDetails(studentsArray[0]);
            Console.WriteLine("\nDetails about the second student:");
            PrintStudentDetails(studentsArray[1]);

            Console.ReadLine();
        }

        private static void AssignStudentDetails(ref Student aStudent, string firstName, string lastName, DateTime birthday)
        {
            // A better way to do this is to ask user for input
            // interactively like we did in last homework, but 
            // here since it's not required I will just assign 
            // them directly.
            aStudent.FirstName = firstName;
            aStudent.LastName = lastName;
            aStudent.BirthDay = birthday;
        }

        private static void PrintStudentDetails(Student aStudent)
        {
            Console.WriteLine("Name: " + aStudent.FirstName + " " + aStudent.LastName);
            Console.WriteLine("Birthday: " + aStudent.BirthDay.ToShortDateString());
        }
    }
}
