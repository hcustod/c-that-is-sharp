using System; 

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int userGuess = 0;

            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            while (userGuess != numberToGuess)
            {
                Console.WriteLine("Enter your guess: ");
                string userInput = Console.ReadLine();
                if (!int.TryParse(userInput, out userGuess))
                {
                    Console.WriteLine("Thats not a number. Try again!");
                    continue;
                }

                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again!");
                } 
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
            }

            Console.WriteLine("You guessed it! The number was " + numberToGuess);
        }

    }
}
