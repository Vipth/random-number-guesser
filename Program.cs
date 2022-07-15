using System;

namespace RandomNumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);
            int maxTries = 5;

            Console.WriteLine("Guess a number between 1-100! You have 5 tries.");

            while (maxTries > 0)
            {
                Console.Write("Your Guess: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess != randomNumber)
                {
                    maxTries -= 1;

                    if (userGuess > randomNumber) { Console.WriteLine($"Try Lower! You have {maxTries} tries left."); }
                    else { Console.WriteLine($"Try Higher! You have {maxTries} tries left."); }
                }
                else
                {
                    Console.WriteLine("Correct! Congratulations!");
                    break;
                }
            }
            if (maxTries == 0) { Console.WriteLine("Game Over! You lose!"); }
        }
    }
}
