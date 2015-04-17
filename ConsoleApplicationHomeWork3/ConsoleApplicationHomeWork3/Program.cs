using System;

namespace ConsoleApplicationHomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            // just a illustration of the exception handling.
            try
            {
                GetStudentInfo();
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine("The format of you last input is incorrect!");
            }
            catch (ArgumentOutOfRangeException arguEx)
            {
                Console.WriteLine("Your last input is out of range!");
            }  

            GetCourseInfo();
            GetTeacherInfo();
            GetProgramInfo();
            GetDegreeInfo();

            Console.ReadLine();
            //ValidateStudentBirthday();
        }

/*
        private static void ValidateStudentBirthday()
        {
            throw new NotImplementedException();
        }
*/

        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birth year: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student's birth month: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student's birth date: ");
            int birthDate = Convert.ToInt32(Console.ReadLine());
            DateTime birthday = new DateTime(birthYear, birthMonth, birthDate);
            PrintStudentDetails(firstName, lastName, birthday.ToShortDateString());
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}.", first, last, birthday);
        }

        static void GetCourseInfo()
        {
            Console.WriteLine("Enter course name: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter the course code: ");
            string courseCode = Console.ReadLine();
            Console.WriteLine("Enter the semester of the course: ");
            string semester = Console.ReadLine();

            PrintCourseDetails(courseName, courseCode, semester);
        }

        static void PrintCourseDetails(string name, string code, string semester)
        {
            Console.WriteLine("This course: {0}: {1} will be held in {2}.", code, name, semester);
        }

        static void GetTeacherInfo()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's department: ");
            string department = Console.ReadLine();

            PrintTeacherDetails(firstName, lastName, department);
        }

        static void PrintTeacherDetails(string first, string last, string department)
        {
            Console.WriteLine("{0} {1} is a teacher in {2}", first, last, department);
        }
        
        static void GetProgramInfo()
        {
            Console.WriteLine("Enter name of the program: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter department that offers this program: ");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Enter the name of the department head: ");
            string departmentHeadName = Console.ReadLine();

            PrintProgramDetails(programName, departmentName, departmentHeadName);
        }

        static void PrintProgramDetails(string name, string dep, string depHead)
        {
            Console.WriteLine("{0} is a program offered by {1}. This department is led by {2}.", name, dep, depHead);
        }

        static void GetDegreeInfo()
        {
            Console.WriteLine("Enter name of the degree: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter length of the degree: ");
            string length = Console.ReadLine();
            Console.WriteLine("Enter required credit to complete the degree: ");
            string credit = Console.ReadLine();

            PrintDegreeDetails(name, length, credit);
        }

        static void PrintDegreeDetails(string name, string length, string credit)
        {
            Console.WriteLine("This degree {0} will last {1}, and require {2} credits to complete.", name, length, credit);
        }
    }
}
