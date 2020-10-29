using System;

namespace ch02_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string str1 = "Elvis";
            String str2 = "Presley";

            var fullName = str1 + " " + str2;
            double d1;
            double d2;

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("enter a decimal value:  ");
                d1 = Double.Parse(Console.ReadLine());
                Console.Write("enter a decimal value:  ");
                d2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("sum is " + (d1 + d2));
                Console.Write("Continue?  ");
                choice = Console.ReadLine();
                Console.WriteLine("");
            }

            Console.Write("Stoplight Color (r, y,g): ");
            String lightColor = Console.ReadLine();

            if (lightColor.Equals("r")) {
                Console.WriteLine("stop!!");
             }

            else if(lightColor.Equals("y")) {
                Console.WriteLine("Slow down");
            }


            else if (lightColor.Equals("g")) {
                Console.WriteLine("Go!!");
            }

            else
            {
                Console.WriteLine("Invalid Color");
            }

        }
    }
}
