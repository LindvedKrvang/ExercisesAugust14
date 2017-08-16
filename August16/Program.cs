using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using August16.bll;
using August16.gui;

namespace August16
{
    class Program
    {
        public static Utility utility;
        public static Printer printer;

        static void Main(string[] args)
        {
            utility = new Utility();
            printer = new Printer();
            //ExerciseOne();
            //ExerciseTwo();
            //ExerciseThree();
            //ExerciseFive();
            ExerciseSix();
        }

        /// <summary>
        /// Exercise One. Enter ten numbers and print them.
        /// </summary>
        public static void ExerciseOne()
        {
            Console.WriteLine("Exercise One!");
            var amountOfNumbers = 10;
            var numbers = utility.GetListOfNumbers(amountOfNumbers);

            Console.WriteLine("The entered numbers are: ");
            printer.PrintListOfNumbers(numbers);
        }

        /// <summary>
        /// Exercise Two. Enter a numbers in a list defined by the user. Then reverse it and print it.
        /// </summary>
        public static void ExerciseTwo()
        {
            Console.WriteLine("Exercise Two!");
            Console.WriteLine("Please enter how long you want your list to be: ");
            var lengthOfList = utility.PromptNumber();
            var numbers = utility.GetListOfNumbers(lengthOfList);

            Console.WriteLine("The entered numbers are: ");
            printer.PrintListOfNumbers(numbers);

            numbers.Reverse();
            Console.WriteLine("The reversed order are: ");
            printer.PrintListOfNumbers(numbers);
        }

        /// <summary>
        /// Exercise Three. Enter a list and calculate the sum.
        /// </summary>
        public static void ExerciseThree()
        {
            Console.WriteLine("Exercise Three!");
            Console.WriteLine("Please enter how long you want your list to be: ");
            var lengthOfList = utility.PromptNumber();
            var numbers = utility.GetListOfNumbers(lengthOfList);

            Console.WriteLine("The entered numbers are: ");
            printer.PrintListOfNumbers(numbers);

            var sum = utility.GetSumOfNumbers(numbers);
            Console.WriteLine($"The sum of the numbers are {sum}.");
        }

        /// <summary>
        /// Exercise Five. Enter a list and check for duplicates.
        /// </summary>
        public static void ExerciseFive()
        {
            Console.WriteLine("Exercise Five!");
            Console.WriteLine("Please enter how long you want your list to be: ");
            var lengthOfList = utility.PromptNumber();
            var numbers = utility.GetListOfNumbers(lengthOfList);

            var duplicates = utility.GetDuplicatesInList(numbers);
            Console.WriteLine("These numbers were duplicates:");
            printer.PrintSetOfNumbers(duplicates);
        }

        /// <summary>
        /// Exercise Six. Enter a list and find all the unique numbers.
        /// </summary>
        public static void ExerciseSix()
        {
            Console.WriteLine("Exercise Six!");
            Console.WriteLine("Please enter how long you want your list to be: ");
            var lengthOfList = utility.PromptNumber();
            var numbers = utility.GetListOfNumbers(lengthOfList);

            var uniqueNumbers = utility.GetUniqueElementsInAList(numbers);
            Console.WriteLine("The unique numbers are:");
            printer.PrintSetOfNumbers(uniqueNumbers);
        }
    }
}