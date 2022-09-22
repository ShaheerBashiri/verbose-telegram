using System;

namespace RNGguess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Random random = new Random();
            bool playAgain = true;
            int minimum = 1;
            int maximum = 100;
            int guess;
            int num;
            int guesses;
            String response;

            while (playAgain)
            {
                playAgain=false;
                guess = 0;
                guesses = 0;
                response = "";
                num = random.Next(minimum, maximum + 1);

                while (guess != num)
                {
                    Console.WriteLine("Guess a number between " + minimum + " - " + maximum + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > num)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + num);
                Console.WriteLine("Congrats, you won!");
                Console.WriteLine("It took you " + guesses + " guesses to guess the correct number.");

                Console.WriteLine("Would you like to play again (y/n): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}