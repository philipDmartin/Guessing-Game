using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 11);


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("guess a number between 1 and 10");
                string userGuess = Console.ReadLine();
                int userGuessInt = int.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine($"you guessed it, it was the number {secretNumber}");
                    return;
                }
                else if (userGuessInt < secretNumber)
                {
                    Console.WriteLine("too low");
                }
                else if (i == 2 && userGuessInt != secretNumber)
                {
                    Console.WriteLine($"{secretNumber} you fucking peice of shit!");
                }
                else
                {
                    Console.WriteLine("too high");
                }
            }
        }
    }
}
