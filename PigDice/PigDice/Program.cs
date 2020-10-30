using System;

namespace PigDice
{
    class Program
    {
       

        public static int timesToPlay { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Pig Dice");

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("How many times to play?");
                timesToPlay = Int32.Parse(Console.ReadLine());
                Int32 timesPlayed = 0;
                Int32 maxDice = 0;
                while (timesToPlay > timesPlayed)
                {
                    Int32 diceRoll = 0;
                    Int32 totDice = 0;
                    
                    while (diceRoll != 1)
                    {
                        Random dice = new Random();
                        diceRoll = dice.Next(1, 7);
                        totDice += diceRoll;
               //         Console.WriteLine(diceRoll+ "      " + totDice);

                    }
               //     Console.WriteLine(totDice + "      " + maxDice);
                    if (totDice > maxDice)
                    {
                        maxDice = totDice;
                    }
                    timesPlayed++;
               //     Console.WriteLine(" times Played     " + timesPlayed);
                }
                Console.WriteLine("Played "  + timesToPlay + " games");
                Console.WriteLine("Highest Score is " + maxDice);
                Console.Write("Continue?  ");
                choice = Console.ReadLine();
                Console.WriteLine("");





            }
            Console.WriteLine("Bye");
        }
    }
}
