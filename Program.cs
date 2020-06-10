using System;

// Namespace
namespace GuessTheNumber
{
    // Main Class
    class Program
    {
        // Error Message
        static void returnError(string errorMessage)
        {
            // Chage Text Color
            Console.ForegroundColor = ConsoleColor.Red;
            //Write Out App Info
            Console.WriteLine(errorMessage);
            // Revert Text Color
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        // Success Message
        static void returnSuccess(string successMessage)
        {
            // Output Success Message
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Tell User They Are Correct.
            Console.WriteLine(successMessage);
            // Revert Text Color
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        // Entry Point
        static void Main(string[] args)
        {
            // Check If Game Is Restarted
            bool newGame = true;
            while (newGame)
            { // Global While Loop, Contains Entire Game
                // Return Header Message
                string successMessage = "Number Guesser: Version 1.0.0 by Jaylan Snelson";
                returnSuccess(successMessage);

                // Ask Users Name
                Console.WriteLine("What is your name?");

                string userName = Console.ReadLine();
                Console.WriteLine("Hello, {0}. Lets play a game!", userName);

                // Get Random Number
                Random random = new Random();
                int randomNumber = random.Next(1, 11);

                // Setting default guess to force while loop
                int guess = 0;

                // Get User Number, Check Agains Randome Number
                Console.WriteLine("Guess a number between 1 and 10.");

                while (guess != randomNumber)
                {
                    string userGuess = Console.ReadLine();

                    // Validate If Number
                    if (!int.TryParse(userGuess, out guess))
                    {
                        string errorMessage = "Please insert a number...";
                        returnError(errorMessage);

                        continue;
                    };

                    // Change To int And Put In guess
                    guess = Int32.Parse(userGuess);

                    // Match Guess To Correct Number
                    if (guess != randomNumber)
                    {
                        string errorMessage = "Wrong number, please try again!";
                        returnError(errorMessage);
                    };
                };

                // Output Success Message
                Console.ForegroundColor = ConsoleColor.Yellow;
                // Tell User They Are Correct.
                Console.WriteLine("Congrats! You Are Correct!");
                // Revert Text Color
                Console.ForegroundColor = ConsoleColor.Gray;

                // Restart Game? Yes/No
                Console.WriteLine("Would you like to play again? Type 'yes' or 'no'");
                string startNewGame = Console.ReadLine();
                bool newGameValidator = true;

                while (newGameValidator)
                {
                    if (startNewGame != "yes" && startNewGame != "no")
                    {
                        string errorMessage = "Please insert either 'yes' or 'no'";
                        returnError(errorMessage);

                        startNewGame = Console.ReadLine();
                    }
                    if (startNewGame == "yes") { Console.WriteLine("Restarting game..."); newGameValidator = false; continue; }
                    if (startNewGame == "no") { newGame = false; newGameValidator = false; }
                }
            }


        }
    }
}
