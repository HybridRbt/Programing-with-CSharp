using System;

namespace ConsoleApplicationHomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowNumber = 8;
            int colNumber = 8;
            string currentPattern;

            for (int i = 0; i < rowNumber; i++)
            {
                if (i % 2 == 0) //rowNumber is even, starts with "X"
                {
                    currentPattern = "X";
                }
                else
                {
                    currentPattern = "O";
                }
                
                for (int j = 0; j < colNumber; j++)
                {
                    Console.Write(currentPattern);
                    if (currentPattern == "X")
                    {
                        currentPattern = "O";
                    }
                    else
                    {
                        currentPattern = "X";
                    }
                }

                Console.Write("\n");  // next line
            }
            Console.ReadLine();
        }
    }
}
