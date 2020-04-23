using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessinggame
{
    class Program
    {
        static void Main()
        {

            uint pickLevel;
            Console.WriteLine("Welcome to my Guessing Game...");
            Console.WriteLine("Select a Difficulty Level: \n1. Easy \n2. Medium \n3. Hard");
            Console.WriteLine("Difficulty level selected : ");

            while(!(uint.TryParse(Console.ReadLine(), out pickLevel)) || pickLevel > 3 || pickLevel == 0)
            {
                Console.Write("Invalid Response. Please Input a aValid Response (1, 2 or 3): ");
            }

            if (pickLevel == 1)
            {
                easy();
            }
            else if (pickLevel == 2)
            {
                medium();
            }
            else 
            {
                hard();
            }
        }

        public static void easy()
        {
            Random numNum = new Random();
            int tries = 1;
            int answer = numNum.Next (1, 11);
            int guess;

            Console.WriteLine("You have selected EASY mode. You have 6 guesses");
            Console.Write("Guess a number between 1 and 10: ");

            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.Write("Invalid Response. Please type in a anumber between 1 to 10 : ");
            }

            while (tries != 6 && answer != guess)
            {
                Console.WriteLine("That was wrong");
                Console.Write("You have "+ (6 - tries)+ " guesses left. Guess again : ");
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Invalid Response. Please type in a anumber between 1 to 10 : ");
                }
                tries++;
            }

            if (answer == guess)
            {
                Console.WriteLine("You got it Right!");
            }
            else 
            {
                Console.WriteLine("Game Over!");
            }
            Console.WriteLine("Thank you for Playing");
            Console.Write("Press any Key to exit ");
            Console.ReadKey(true);
        
        }

        public static void medium()
        {
            Random numNum = new Random();
            int tries = 1;
            int answer = numNum.Next (1, 21);
            int guess;

            Console.WriteLine("You have selected MEDIUM mode. You have 4 guesses");
            Console.Write("Guess a number between 1 and 20: ");

            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.Write("Invalid Response. Please type in a anumber between 1 to 20 : ");
            }

            while (tries != 4 && answer != guess)
            {
                Console.WriteLine("That was wrong");
                Console.Write("You have "+ (4 - tries)+ " guesses left. Guess again : ");
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Invalid Response. Please type in a number between 1 to 20 : ");
                }
                tries++;
            }

            if (answer == guess)
            {
                Console.WriteLine("You got it Right!");
            }
            else 
            {
                Console.WriteLine("Game Over!");
            }
            Console.WriteLine("Thank you for Playing");
            Console.Write("Press any Key to exit ");
            Console.ReadKey(true);
            
        }

         public static void hard()
        {
            Random numNum = new Random();
            int tries = 1;
            int answer = numNum.Next (1, 51);
            int guess;

            Console.WriteLine("You have selected HARD mode. You have 3 guesses");
            Console.Write("Guess a number between 1 and 50: ");

            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.Write("Invalid Response. Please type in a anumber between 1 to 50 : ");
            }

            while (tries != 3 && answer != guess)
            {
                Console.WriteLine("That was wrong");
                Console.Write("You have "+ (3 - tries)+ " guesses left. Guess again : ");
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Invalid Response. Please type in a number between 1 to 50 : ");
                }
                tries++;
            }

            if (answer == guess)
            {
                Console.WriteLine("You got it Right!");
            }
            else 
            {
                Console.WriteLine("Game Over!");
            }

            Console.WriteLine("Thank you for Playing");
            Console.Write("Press any Key to exit ");
            Console.ReadKey(true);
            
        }

            
    }
}

