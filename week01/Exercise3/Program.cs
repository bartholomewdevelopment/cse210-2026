using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            int guessCount = 1;


            while (guess != magicNumber)
            {
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again?  yes or no: ");
            playAgain = Console.ReadLine().ToLower();
        }    
    }
}