using System;

namespace ch03_02_TravelTimeConverter
{
    class Program
    {
        private static double milesPerHour;
        private static double TravelTime;
        private static int IntTravelTime;
        private static double AmtLeft;
        private static double Minutes;
        private static double miles;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter miles  ");
                miles = Double.Parse(Console.ReadLine());
                Console.Write("enter miles per hour:  ");
                milesPerHour = Double.Parse(Console.ReadLine());
                TravelTime = miles / milesPerHour;
                
                IntTravelTime = (int)(miles / milesPerHour);
                AmtLeft = TravelTime - IntTravelTime;
                Minutes = AmtLeft / 60;
                
                Console.Write(IntTravelTime + "   " + Minutes);

                Console.Write("Continue?  ");
                choice = Console.ReadLine();
                Console.WriteLine("");



            }
        }
    }
}
