using System;

namespace ch05_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 5");
           
            int nbr = ParseInt("Enter a whole number:   ");



            PrintOrderDetails("Target", 33, "Light up Pumpkin");

            PrintCandyStats("Snickers ", 5);
            PrintCandyStats("Snickers ");
            PrintFavSong("Accidents will Happen");
        }

        private static int ParseInt(String prompt)
        {
            int n = 0;
            while (true)
            {
                Console.WriteLine(prompt);
                try
                {
                    n = int.Parse(Console.ReadLine());
                    break;
                    
                }
                catch (Exception)
                {

                    Console.WriteLine("Hey!");

                }
            
             return n;
            }
           

        }

            private static void PrintOrderDetails(String sellerName, int orderNum, String productName)
        {

            Console.WriteLine("OrderDetails:  " + productName + ", on " +  "order #" + orderNum 
                                    + ", purchased at " + sellerName + ".");

        }

        private static void PrintCandyStats(String candyName, int quantity = 0)
        {
            Console.WriteLine("* " + quantity+ " pieces of " + candyName);
        }

        private static void PrintFavSong(String name)
        {
            Console.WriteLine("My favorite song is " + name + ".");
            Console.WriteLine($"My favorite song is {name}.");
        }

    }
}
