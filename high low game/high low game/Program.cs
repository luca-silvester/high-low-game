using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace high_low_game
{
    class Program
    {
        static void Main(string[] args)

        {

            Random r = new Random();

            int val = r.Next(1, 50);
            int guess = 0;
            bool correct = false;

            Console.WriteLine("I'm thinking of a number between 1 - 50.");

            while (!correct)
            {
                Console.Write("Guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("That's not a number.");
                    continue;
                }

                if (guess < val)
                {
                    Console.WriteLine("Higher. ");
                }
                else if (guess > val)
                {
                    Console.WriteLine("Lower. ");
                }
                else
                {
                    correct = true;
                    Console.WriteLine("You guessed right!");
                    Console.ReadLine();
                }
            }

        }
    }
}
