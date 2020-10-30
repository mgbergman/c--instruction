using System;

namespace ch04_proj1_TableOfPowers
{
    class Program
    {
        private static int d1Square;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes table");
            int d1;

            String choice = "y";
            while (choice.Equals("y"))
            {
                d1 = GetNumber();
                Console.WriteLine("Number          Squared        Cubed");

                for (int i = 1; i <= d1; i++)
                {
                    d1Square = i * i;
                    int d1Cube = i * i * i;
                    Console.WriteLine(i + "       " + d1Square + "        " + d1Cube);

                }

                Console.Write("Continue?  ");
                choice = Console.ReadLine();
                Console.WriteLine("");




            }
        }

        private static int GetNumber()
        {
            int d1;
            Console.WriteLine("Enter an integer:   ");
            while (true)
            {
                try
                {
                    d1 = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Hey!  Enter something valid!");
                }
            }
            return d1;
        }
    } 
    }


