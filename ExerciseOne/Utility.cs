using System;

namespace ExerciseOne
{
    public class Utility
    {
        /// <summary>
        /// Prompts for two numbers and returns them.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        public void PromptTwoNumbers(out int firstNumber, out int secondNumber) {
            Console.WriteLine("Please enter a number:");
            PromptNumber(out firstNumber);
            Console.WriteLine("Please enter a second number:");
            PromptNumber(out secondNumber);
        }

        /// <summary>
        /// Prompts for a number. If it's not a valid number. Prompts for a new one.
        /// </summary>
        /// <param name="number"></param>
        public void PromptNumber(out int number) {
            if (!int.TryParse(Console.ReadLine(), out number)) {
                Console.WriteLine("That's not a valid number. Try again.");
                PromptNumber(out number);
            }
        }

        /// <summary>
        /// Displays a number many times according to exercise twelve.
        /// </summary>
        /// <param name="number"></param>
        public void DisplayNumberManyTimes(int number)
        {
            var timesToIterate = 4;
            var message = "";
            for (var i = 0; i <= timesToIterate ; i++)
            {
                message += $"{number} ";
            }
            var secondMessage = "";
            for (var i = 0; i < timesToIterate; i++)
            {
                secondMessage += number;
            }
            Console.WriteLine(message);
            Console.WriteLine(secondMessage);
        }

        /// <summary>
        /// Displays a rectangle of the given number. Used for exercise thirteen.
        /// </summary>
        /// <param name="number"></param>
        public void DisplayRectangle(int number)
        {
            var fullLine = $"{number}{number}{number}";

            //Creates the side block with as many spaces in the middle as there is characters in the number.
            var amountOfChars = number.ToString().ToCharArray().Length;
            var side = $"{number}";
            for (var index = 0; index < amountOfChars; index++)
            {
                side += " ";
            }
            side += number;

            var rows = 5;

            for (var i = 0; i < rows; i++)
            {
                if (i > 0 && i < rows - 1)
                {
                    Console.WriteLine(side);
                }
                else
                {
                    Console.WriteLine(fullLine);
                }
            }
        }
    }
}