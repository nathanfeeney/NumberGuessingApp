using System;

namespace NumberGuessingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);
            bool win = false;

            do
            {
                Console.Write("Guess a number inbetween 0 and 100: ");
                string s = Console.ReadLine();
                int i = int.Parse(s);

                if( i > winNum)
                {
                    Console.Write("Too high! try again");
                }
                else if (i < winNum)
                {
                    Console.Write("Too low! try again");

                }
                else if (i == winNum)
                {
                    Console.Write("You WIN!");
                    win = true;
                }

                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("Thank you for playing");
            Console.Write("Press any key to finish");
            Console.ReadKey(true);
        }
    }
}
