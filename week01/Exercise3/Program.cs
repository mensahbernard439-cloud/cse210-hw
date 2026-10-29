using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            Console.WriteLine("\nWelcome to the Guess My Number Game!");

            // Generate a random magic number from 1 to 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            
            // 1. Keep track of how many guesses the user makes
            int guessCount = 0;

            // Inner loop: keep guessing until they get it right
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                
                // Every time they guess, add 1 to the counter
                guessCount++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Inform them of how many guesses it took
            Console.WriteLine($"It took you {guessCount} guesses.");

            // Ask if they want to play again
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine().ToLower(); // Converts input to lowercase just in case
        }

        Console.WriteLine("Thanks for playing!");
    }
    }
