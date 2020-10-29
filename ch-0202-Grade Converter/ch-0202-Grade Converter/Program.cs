using System;

namespace ch_0202_Grade_Converter
{
    class Program
    {
        private static double gradeNumber;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter");

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("enter a numerical grade  ");
                gradeNumber = Double.Parse(Console.ReadLine());

                if (gradeNumber > 87)
                {
                    Console.WriteLine("A");
                }

                else if (gradeNumber > 79)
                {
                    Console.WriteLine("B");
                }


                else if (gradeNumber > 66)
                {
                    Console.WriteLine("C");

                }

                else if (gradeNumber > 59)
                {
                    Console.WriteLine("D");

                }

                else
                {
                    Console.WriteLine("F");
                }

                Console.Write("Continue?  ");
                choice = Console.ReadLine();
                Console.WriteLine("");
            }
        }
    }
}
