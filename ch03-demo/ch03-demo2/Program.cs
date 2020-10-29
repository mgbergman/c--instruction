using System;

namespace ch03_demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                ;
                int r1 = rand.Next(10, 20);
                Console.WriteLine(r1);
            }
            double d1 = 85.57888898;
            Console.WriteLine(d1);
            Console.WriteLine(Math.Round(d1));


            double d2 = 199.99;
            Console.WriteLine(d2.ToString("C"));


        }
    }
}
