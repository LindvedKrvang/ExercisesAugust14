using System;
using System.Runtime.InteropServices.ComTypes;

namespace ExerciseOne
{
    class Program
    {
        private static Utility utility;

        static void Main(string[] args)
        {
            utility = new Utility();
            //ExerciseOne();
            //ExerciseTwo();
            //ExerciseThree();
            //ExerciseFour();
            //ExerciseFive();
            //ExerciseSix();
            //ExerciseSeven();
            //ExerciseEigth();
            //ExerciseNine();
            //ExerciseTen();
            //ExerciseEleven();
            //ExerciseTwelve();
            ExerciseThirteen();
        }

        /// <summary>
        /// Exercise 1. Prompt name.
        /// </summary>
        private static void ExerciseOne()
        {
            Console.WriteLine("Exercise One!");
            Console.WriteLine("Please enter your name:");
            var input = Console.ReadLine();
            Console.WriteLine($"Hello {input}");
        }

        /// <summary>
        /// Exercise 2. Add two numbers.
        /// </summary>
        private static void ExerciseTwo()
        {
            Console.WriteLine("Exercise Two!");
            utility.PromptTwoNumbers(out int firstNumber, out int secondNumber);

            var sum = firstNumber + secondNumber;
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {sum}.");
        }

        /// <summary>
        /// Exercise Three. Divide two numbers.
        /// </summary>
        private static void ExerciseThree()
        {
            Console.WriteLine("Exercise Three!");
            utility.PromptTwoNumbers(out int firstNumber, out int secondNumber);
            if (secondNumber < 1)
            {
                Console.WriteLine($"You can't divided with {secondNumber}! \nEnter a new number:");
                utility.PromptNumber(out secondNumber);
            }

            float dividedNumber = firstNumber / secondNumber;
            Console.WriteLine($"{firstNumber} divided with {secondNumber} is {dividedNumber}.");
        }

        /// <summary>
        /// Exercise Four. Do the four alogrithms.
        /// </summary>
        private static void ExerciseFour()
        {
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
        private static void ExerciseFive()
        {
            Console.WriteLine("Exercise Five!");
            utility.PromptTwoNumbers(out int firstNumber, out int secondNumber);

            var temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine($"The firstNumber is now {firstNumber}. The secondNumber is now {secondNumber}.");
        }

        /// <summary>
        /// Exercise Six. Multiply three numbers.
        /// </summary>
        private static void ExerciseSix()
        {
            Console.WriteLine("Exercise Six!");
            utility.PromptTwoNumbers(out int firstNumber, out int secondNumber);
            Console.WriteLine("Enter a third number:");
            utility.PromptNumber(out int thirdNumber);

            var multipliedNumber = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine(
                $"{firstNumber}, {secondNumber} and {thirdNumber} multiplied together is {multipliedNumber}.");
        }

        /// <summary>
        /// Exercise 7. Add. Multiply. Divide. Modulus.
        /// </summary>
        private static void ExerciseSeven()
        {
            Console.WriteLine("Exercise Seven!");
            utility.PromptTwoNumbers(out int firstNumber, out int secondNumber);

            //Checks if the second number is not zero or a negative number.
            if (secondNumber < 1) {
                Console.WriteLine($"You can't divided with {secondNumber}! \nEnter a new number:");
                utility.PromptNumber(out secondNumber);
            }

            var sum = firstNumber + secondNumber;
            var multiplied = firstNumber * secondNumber;
            var divided = firstNumber / secondNumber;
            var modulus = firstNumber % secondNumber;

            Console.WriteLine($"Your numbers are {firstNumber} and {secondNumber}.");
            Console.WriteLine($"The sum is: {sum}.");
            Console.WriteLine($"The multiplied number is: {multiplied}.");
            Console.WriteLine($"The divided number is: {divided}.");
            Console.WriteLine($"The modilus is: {modulus}.");
        }

        /// <summary>
        /// Exercise Eigth. Choose a multiplier and multiply.
        /// </summary>
        private static void ExerciseEigth()
        {
            Console.WriteLine("Exercise Eigth!");
            Console.WriteLine("Enter a number:");
            utility.PromptNumber(out int multiplier);

            var amountOfTurns = 10;
            for (int i = 0; i <= amountOfTurns; i++)
            {
                var multipliedNumber = multiplier * i;
                Console.WriteLine($"{multiplier} * {i} = {multipliedNumber}.");
            }
        }

        /// <summary>
        /// Exercise Nine. Average of four numbers.
        /// </summary>
        private static void ExerciseNine()
        {
            Console.WriteLine("Exerise Nine!");
            utility.PromptTwoNumbers(out int firstNumber, out int secondNumber);
            utility.PromptTwoNumbers(out int thirdNumber, out int fourthNumber);

            var amountOfNumbers = 4;
            var averageNumber = (firstNumber + secondNumber + thirdNumber + fourthNumber) / amountOfNumbers;

            Console.WriteLine($"The average number of {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is {averageNumber}.");
        }

        /// <summary>
        /// Exerise Ten. Three inputs with specified result.
        /// </summary>
        private static void ExerciseTen()
        {
            Console.WriteLine("Exercise Ten!");
            utility.PromptTwoNumbers(out int firstNumber, out int secondNumber);
            Console.WriteLine("Please enter a third number:");
            utility.PromptNumber(out int thirdNumber);

            var firstOutput = (firstNumber + secondNumber) * thirdNumber;
            var secondOutput = firstNumber * secondNumber + secondNumber * thirdNumber;

            Console.WriteLine($"Result of specified numbers {firstNumber}, {secondNumber} and {thirdNumber} " +
                              $"(x+y)*z is {firstOutput} and (x*y)+(y*z) is {secondOutput}.");
        }

        /// <summary>
        /// Exercise Eleven. Ask for your age and show it.
        /// </summary>
        private static void ExerciseEleven()
        {
            Console.WriteLine("Exercise Eleven");
            Console.WriteLine("Please enter your age:");
            utility.PromptNumber(out int age);

            Console.WriteLine($"You look older than {age}.");
        }

        /// <summary>
        /// Exercise Twelve. Print a number many times.
        /// </summary>
        private static void ExerciseTwelve()
        {
            Console.WriteLine("Exercise Twelve!");
            Console.WriteLine("Please enter a number: ");
            utility.PromptNumber(out int number);

            utility.DisplayNumberManyTimes(number);
            utility.DisplayNumberManyTimes(number);
        }

        /// <summary>
        /// Exercise Thirteen. Display a rectangle.
        /// </summary>
        private static void ExerciseThirteen()
        {
            Console.WriteLine("Exercise Thirteen!");
            Console.WriteLine("Please enter a number:");
            utility.PromptNumber(out int number);
            utility.DisplayRectangle(number);
        }
    }
}