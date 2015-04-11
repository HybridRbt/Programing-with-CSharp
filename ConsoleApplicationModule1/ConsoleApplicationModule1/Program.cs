using System;

namespace ConsoleApplicationModule1
{
    class Program
    {
        static void Main(string[] args)
        {
            //**** student information ***//
            string firstName = "John";
            string lastName = "Down";
            DateTime birthDate = new DateTime(85, 1, 20);
            string addressLine1 = "9900 Independent Pkwy";
            string addressLine2 = "Room 335";
            string city = "Irving";
            string stateOrProvince = "TX";
            string zipOrPostal = "70605";
            string country = "U.S.A";

            //**** professor information ***//
            string professorName = "Reese Finch";
            string professorMajor = "Computer Science";

            //**** degree info ***//
            string degreeName = "Bachelor of Science in Information Technology";
            int degreeCreditsReq = 30;

            //**** university program ***//
            string programName = "Computer Science";
            string degreesOffered = "Bachelor";
            string departmentHead = "Root Grooves";

            //**** course info ***//
            string courseName = "Programming with C#";
            string courseIntro = "This course aims to teach the basics of C# all the way through the advanced features of the language. " +
                                 "This course is not a beginner course on C#, although beginners can still learn a lot from the material." +
                                 "  It is intended to provide an introduction to the C# language and the world of .NET programming for" +
                                 " existing programmers who need or want to learn more about C# and managed code development.";

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Birth Day: " + birthDate);
            Console.WriteLine("Address Line 1: " + addressLine1);
            Console.WriteLine("Address Line 2: " + addressLine2);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State: " + stateOrProvince);
            Console.WriteLine("Zip: " + zipOrPostal);
            Console.WriteLine("Country: " + country);

            Console.WriteLine("My profesor is: " + professorName);
            Console.WriteLine("And his major is: " + professorMajor);

            Console.WriteLine("My degree is: " + degreeName + ", which requires " + degreeCreditsReq + " credits to complete.");
            Console.WriteLine("My program is: " + programName + ", with " + departmentHead
                              + " as the department head. And they offer " + degreesOffered + " in the program.");

            Console.WriteLine("My current course is: " + courseName + ". " + courseIntro);
            Console.ReadLine();
        }
    }
}
