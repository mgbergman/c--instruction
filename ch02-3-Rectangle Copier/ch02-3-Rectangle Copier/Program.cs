using System;

namespace ch02_3_Rectangle_Copier
{
    class Program
    {
        private static double length;
        private static double width;

        static void Main(string[] args)
        {
            String choice = "y";
            while (choice.Equals("y"))
            {

                Console.WriteLine("Welcome to the Area and Perimeter Calculator");
                Console.Write("Enter length  ");
                length = Double.Parse(Console.ReadLine());
                Console.Write("Enter width  ");
                width = Double.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + (width * length));
                Console.WriteLine("Perimeter " + (width + length + width + length));
                Console.Write("Continue?  ");
                choice = Console.ReadLine();
                Console.WriteLine("");
            }
        }
    }
}
