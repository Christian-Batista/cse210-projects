using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int magicNumber = random.Next(1, 101);
            int guess = -1;
            int guesses = 0;

            do {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesses++;
                
                // Determine if the guess is too high or too low or correct
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guesses} guesses.");
                }
            } while (guess != magicNumber);

            // Ask the player if they want to play again
            Console.WriteLine("Do you want to play again? (y/n)");
            string playAgainInput = Console.ReadLine().ToLower();

            //Verify if the answer is correct
            if (playAgainInput != "y" && playAgainInput != "n")
            {
                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                playAgainInput = Console.ReadLine().ToLower();
            }
            // If the player wants to play again, set playAgain to true
            if (playAgainInput == "n") 
            {
                playAgain = false;
            }
            
        }
        Console.WriteLine("Thanks for playing!");
    }
}