using System;
using System.Collections.Generic;
using System.Reflection;

namespace August15 {
    class Program
    {
        private static Utility utility;

        static void Main(string[] args)
        {
            utility = new Utility();
            //ExerciseEigth();
            //ExerciseNineEnumSolution();
            //ExerciseNineStructSolution();
            ExerciseSixteen();
        }

        /// <summary>
        /// Exercise Eigth. Find the higesht of three numbers entered.
        /// </summary>
        private static void ExerciseEigth()
        {
            Console.WriteLine("Exercise Eigth!");
            utility.PromptNumbers(out int firstNumber, out int secondNumber, out int thirdNumber);
            var list = new List<int> {firstNumber, secondNumber, thirdNumber};
            list.Sort();
            list.Reverse();
            Console.WriteLine($"The highest number is {list[0]}.");
        }

        /// <summary>
        /// Exercise Nine Enum Solution. Enter a coordinate. The program tells you which quadrant the coordinate is in.
        /// </summary>
        private static void ExerciseNineEnumSolution()
        {
            Console.WriteLine("Exercise Nine Enum Solution!");
            utility.PromptNumbers(out int firstNumber, out int secondNumber);
            EnumQuadrants enumQuadrant = utility.FindQuadrant(firstNumber, secondNumber);
            utility.WriteQuadrantMessage(firstNumber, secondNumber, enumQuadrant);
        }

        /// <summary>
        /// Exercise Nine Struct Solution. Tried to make the same exercise using Struct instead of Enum. Prefer the Enum solution.
        /// </summary>
        private static void ExerciseNineStructSolution()
        {
            Console.WriteLine("Exercise Nine Struct Solution!");
            utility.PromptNumbers(out int firstNumber, out int secondNumber);
            QuadrantsStruct quadrant = utility.FindQuadrantStruct(firstNumber, secondNumber);
            utility.WriteQuadrantMessage(firstNumber, secondNumber, quadrant);
        }

        /// <summary>
        /// Exercise Sixteen. Check if a letter is a vowel or not.
        /// </summary>
        private static void ExerciseSixteen()
        {
            Console.WriteLine("Exercise Sixteen!");
            Console.WriteLine("Please enter a letter:");
            var letter = utility.PromptLetter();
            bool isVowel = utility.CheckIsVowel(letter);
            if (isVowel)
            {
                Console.WriteLine($"The letter '{letter}' is a vowel.");
            }
            else
            {
                Console.WriteLine($"The letter '{letter}' is not a vowel.");
            }
        }
    }
}