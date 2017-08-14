using System;

namespace August14_2
{
    class Program
    {
        private static Utility utility;

        static void Main(string[] args)
        {
            utility = new Utility();
            //ExerciseOne();
            //ExerciseTwo();
            ExerciseThree();
        }

        /// <summary>
        /// Exercise One. Reverse order.
        /// </summary>
        private static void ExerciseOne()
        {
            Console.WriteLine("Exercise One!");
            Console.WriteLine("Please enter some text:");
            var inputOne = utility.PromptText();
            Console.WriteLine("Please enter some text again:");
            var inputTwo = utility.PromptText();
            Console.WriteLine("Please enter some text for the third time:");
            var inputThree = utility.PromptText();

            Console.WriteLine($"{inputThree}, {inputTwo}, {inputOne}");
        }

        /// <summary>
        /// Exercise Two. Print many numbers.
        /// </summary>
        private static void ExerciseTwo()
        {
            Console.WriteLine("Exercise Two!");
            Console.WriteLine("Please enter a number:");
            var number = utility.PromptNumber();
            Console.WriteLine("Please enter a width:");
            var width = utility.PromptNumber();

            for (int i = 0; i < width; i++)
            {
                var text = "";
                for (int j = 0; j < width - i; j++)
                {
                    text += number;
                }
                Console.WriteLine(text);
            }
        }

        /// <summary>
        /// Exercise Three. Login system.
        /// </summary>
        private static void ExerciseThree()
        {
            Console.WriteLine("Exercise Three!");

            var userId = 10;
            var password = "admin";
            var attempts = 3;

            do
            {
                Console.WriteLine("Please enter your userID:");
                var inputId = utility.PromptNumber();
                Console.WriteLine("Please enter your password:");
                var inputPassword = utility.PromptText();

                if (userId != inputId || password != inputPassword)
                {
                    Console.WriteLine("Sorry. The userID or password does not exits.");
                    attempts--;
                    Console.WriteLine($"You have {attempts} tries left..");
                }
                else
                {
                    Console.WriteLine("You are now logged in.");
                    return;
                }
            } while (attempts > 0);
            Console.WriteLine("You have used all of your attempts and are now locked out off the system.");
        }
    }
}