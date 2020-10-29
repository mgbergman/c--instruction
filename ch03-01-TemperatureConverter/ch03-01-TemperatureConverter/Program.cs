using System;

namespace ch03_01_TemperatureConverter
{
    class Program
    {
        private static double d1;

        static void Main(string[] args)
        {
            String choice = "y";
            while (choice.Equals("y"))
            {


                Console.WriteLine("Welcome to the Temperature Converter");
                Console.WriteLine("Enter degrees in Fahrenheit:   ");
                d1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Degrees in Celsius:  " + (d1 - 32 * 5/9).ToString("F"));
                Console.Write("Continue?  ");
                choice = Console.ReadLine();
                Console.WriteLine("");

            }
        }
    }
}