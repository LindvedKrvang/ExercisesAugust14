using System;

namespace ExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExerciseOne();
            //ExerciseTwo();
            //ExerciseThree();
            //ExerciseFour();
            //ExerciseFive();
            //ExerciseSix();
            ExerciseSeven();
        }

        /// <summary>
        /// Exercise 1. Prompt name.
        /// </summary>
        private static void ExerciseOne() {
            Console.WriteLine("Exercise One!");
            Console.WriteLine("Please enter your name:");
            var input = Console.ReadLine();
            Console.WriteLine($"Hello {input}");
        }

        /// <summary>
        /// Exercise 2. Add two numbers.
        /// </summary>
        private static void ExerciseTwo() {
            Console.WriteLine("Exercise Two!");
            PromptTwoNumbers(out int firstNumber, out int secondNumber);

            var sum = firstNumber + secondNumber;
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {sum}.");
        }

        /// <summary>
        /// Prompts for two numbers and returns them.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        private static void PromptTwoNumbers(out int firstNumber, out int secondNumber) {
            Console.WriteLine("Please enter a number:");
            PromptNumber(out firstNumber);
            Console.WriteLine("Please enter a second number:");
            PromptNumber(out secondNumber);
        }

        /// <summary>
        /// Prompts for a number. If it's not a valid number. Prompts for a new one.
        /// </summary>
        /// <param name="number"></param>
        private static void PromptNumber(out int number) {
            if(!int.TryParse(Console.ReadLine(), out number)) {
                Console.WriteLine("That's not a valid number. Try again.");
                PromptNumber(out number);
            }
        }

        /// <summary>
        /// Exercise Three. Divide two numbers.
        /// </summary>
        private static void ExerciseThree() {
            Console.WriteLine("Exercise Three!");
            PromptTwoNumbers(out int firstNumber, out int secondNumber);
            if(secondNumber < 1) {
                Console.WriteLine($"You can't divided with {secondNumber}! \nEnter a new number:");
                PromptNumber(out secondNumber);
            }

            float dividedNumber = firstNumber / secondNumber;
            Console.WriteLine($"{firstNumber} divided with {secondNumber} is {dividedNumber}.");
        }

        /// <summary>
        /// Exercise Four. Do the four alogrithms.
        /// </summary>
        private static void ExerciseFour() {
            Console.WriteLine("Exercise Four!");
            var firstAlgorithm = -1 + 4 * 6;
            var secondAlgorithm = (35 + 5) / 7;
            var thirdAlgorithm = 14 + (-4) * 6 / 11;
            var fourthAlgorithm = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine($"{firstAlgorithm}\n{secondAlgorithm}\n{thirdAlgorithm}\n{fourthAlgorithm}");
        }

        /// <summary>
        /// Exerise Five. Swap two numbers.
        /// </summary>
        private static void ExerciseFive() {
            Console.WriteLine("Exercise Five!");
            PromptTwoNumbers(out int firstNumber, out int secondNumber);

            var temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine($"The firstNumber is now {firstNumber}. The secondNumber is now {secondNumber}.");
        }

        /// <summary>
        /// Exercise Six. Multiply three numbers.
        /// </summary>
        private static void ExerciseSix() {
            Console.WriteLine("Exercise Six!");
            PromptTwoNumbers(out int firstNumber, out int secondNumber);
            Console.WriteLine("Enter a third number:");
            PromptNumber(out int thirdNumber);

            var multipliedNumber = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine($"{firstNumber}, {secondNumber} and {thirdNumber} multiplied together is {multipliedNumber}.");
        }

        private static void ExerciseSeven() {

        }
    }
}