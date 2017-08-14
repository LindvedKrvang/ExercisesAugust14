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
            //ExerciseThirteen();
            //ExerciseFourteen();
            //ExerciseFifteen();
            //ExerciseSixteen();
            //ExerciseSeventeen();
            //ExerciseEighteen();
            //ExerciseNineteen();
            ExerciseTwenty();
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

        /// <summary>
        /// Exercise Fourteen. Convert temperatures.
        /// </summary>
        private static void ExerciseFourteen()
        {
            Console.WriteLine("Exercise Fourteen!");
            Console.WriteLine("Please enter a temperature in Celsius:");
            utility.PromptNumber(out int temperature);

            var kelvin = temperature + 273.15;
            var fahrenheit = ((temperature * 9) / 5) + 32;

            Console.WriteLine($"Kelvin: {kelvin}\nFahrenheit: {fahrenheit}");
        }

        /// <summary>
        /// Exercise Fifteen. Remove a character from a word.
        /// </summary>
        private static void ExerciseFifteen()
        {
            Console.WriteLine("Exercise Fifteen!");
            Console.WriteLine("Please enter a word:");
            var input = utility.PromptText();

            Console.WriteLine("Now please enter a character to be removed:");
            var toRemove = utility.PromptText();

            Console.WriteLine($"Your word is '{input}' and the character to be removed is '{toRemove}'.");

            var alteredInput = input.Replace(toRemove, "");

            Console.WriteLine($"Your new word is '{alteredInput}'.");
        }

        /// <summary>
        /// Exercise Sixteen. Switch first and last character of a string.
        /// </summary>
        private static void ExerciseSixteen()
        {
            Console.WriteLine("Exercise Sixteen!");
            Console.WriteLine("Please enter a word:");
            var input = utility.PromptText().ToCharArray();

            var lastIndex = input.Length - 1;
            var firstLetter = input[0];
            var lastLetter = input[lastIndex];
            input[0] = lastLetter;
            input[lastIndex] = firstLetter;

            var newWord = new string(input);
            Console.WriteLine($"Your new word is '{newWord}'.");
        }

        /// <summary>
        /// Exercise Seventeen. Add the first character at the beginning and end of a string.
        /// </summary>
        private static void ExerciseSeventeen()
        {
            Console.WriteLine("Exercise Seventeen!");
            Console.WriteLine("Please enter some text:");
            var input = utility.PromptText();
            var firstLetter = input.ToCharArray()[0];

            var formattedString = firstLetter + input + firstLetter;
            Console.WriteLine($"Your new text is '{formattedString}'.");
        }

        /// <summary>
        /// Exercise Eighteen. Check if one number is positive and the other negative.
        /// </summary>
        private static void ExerciseEighteen()
        {
            Console.WriteLine("Exercise Eighteen!");
            utility.PromptTwoNumbers(out int firstNumber, out int secondNumber);

            var isOnePositiveOneNegative = utility.OnePositiveOneNegative(firstNumber, secondNumber);

            Console.WriteLine($"The statment: 'One number is positive. The other is negative' is {isOnePositiveOneNegative}.");
        }

        /// <summary>
        /// Exercise Nineteen. Triple sum.
        /// </summary>
        private static void ExerciseNineteen()
        {
            Console.WriteLine("Exercise Nineteen!");
            utility.PromptTwoNumbers(out int firstNumber, out int secondNumber);

            var sum = firstNumber + secondNumber;

            if (firstNumber == secondNumber)
            {
                sum *= 3;
                Console.WriteLine($"Since {firstNumber} and {secondNumber} are the same number you get their triple sum: {sum}.");
                return;
            }

            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {sum}.");
        }

        /// <summary>
        /// Exercise Twenty. Absolute value.
        /// </summary>
        private static void ExerciseTwenty()
        {
            Console.WriteLine("Exercise Twenty!");
            utility.PromptTwoNumbers(out int firstNumber, out int secondNumber);

            var absoluteValue = (secondNumber < 0)
                ? Math.Abs(firstNumber + secondNumber)
                : Math.Abs(firstNumber - secondNumber);

            if (firstNumber > secondNumber)
            {
                absoluteValue *= 2;
                Console.WriteLine($"{firstNumber} is bigger than {secondNumber} so you get the double absolute value: {absoluteValue}.");
                return;
            }

            Console.WriteLine($"The absolute of the difference between {firstNumber} and {secondNumber} is {absoluteValue}.");
        }
    }
}