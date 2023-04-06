using System;

class Program
{
    static void Main(string[] args)
    {
        // Start the game loop
        while (true)
        {
            // Generate a random number from 1 to 100
            Random rand = new Random();
            int magicNumber = rand.Next(1, 101);

            // Keep track of the number of guesses
            int numGuesses = 0;

            // Get the user's first guess
            Console.Write("Guess the magic number: ");
            int guess = int.Parse(Console.ReadLine());
            numGuesses++;

            // Start a loop for the guessing process
            while (guess != magicNumber)
            {
                if (guess < magicNumber)
                {
                    Console.WriteLine("Guess higher.");
                }
                else
                {
                    Console.WriteLine("Guess lower.");
                }
                Console.Write("Guess the magic number: ");
                guess = int.Parse(Console.ReadLine());
                numGuesses++;
            }

            // The user has correctly guessed the magic number
            Console.WriteLine("Congratulations! You guessed the magic number in {0} guesses.", numGuesses);

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no) ");
            string playAgain = Console.ReadLine();

            // Exit the game loop if the user does not want to play again
            if (!playAgain.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }
    }
}
