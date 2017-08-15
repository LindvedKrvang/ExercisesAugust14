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
            ExerciseNineStructSolution();
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

            switch (enumQuadrant)
            {
                case EnumQuadrants.FirstQuadrant:
                {
                    utility.WriteQuadrantMessage(firstNumber, secondNumber, enumQuadrant);
                    break;
                }
                case EnumQuadrants.SecondQuadrant:
                {
                    utility.WriteQuadrantMessage(firstNumber, secondNumber, enumQuadrant);
                    break; 
                }
                case EnumQuadrants.ThirdQuadrant:
                {
                    utility.WriteQuadrantMessage(firstNumber, secondNumber, enumQuadrant);
                    break;
                }
                case EnumQuadrants.FourthQuadrant:
                {
                    utility.WriteQuadrantMessage(firstNumber, secondNumber, enumQuadrant);
                    break;
                }
                case EnumQuadrants.Oregon:
                {
                    utility.WriteQuadrantMessage(firstNumber, secondNumber, enumQuadrant);
                    break;
                }
            }
        }

        /// <summary>
        /// Exercise Nine Struct Solution. Tried to make the same exercise using Struct instead of Enum. Prefer the Enum solution.
        /// </summary>
        private static void ExerciseNineStructSolution()
        {
            Console.WriteLine("Exercise Nine Struct Solution!");
            utility.PromptNumbers(out int firstNumber, out int secondNumber);
            QuadrantsStruct quadrant = utility.FindQuadrantStruct(firstNumber, secondNumber);

            switch (quadrant.quadrant)
            {
                case Constants.FIRST_QUADRANT:
                {
                    utility.WriteQuadrantMessage(firstNumber, secondNumber, quadrant);
                    break;
                }
                case Constants.SECOND_QUADRANT:
                {
                    utility.WriteQuadrantMessage(firstNumber, secondNumber, quadrant);
                    break;
                }
                case Constants.THIRD_QUADRANT:
                {
                    utility.WriteQuadrantMessage(firstNumber, secondNumber, quadrant);
                    break;
                }
                case Constants.FOURTH_QUARDANT:
                {
                    utility.WriteQuadrantMessage(firstNumber, secondNumber, quadrant);
                    break;
                }
                case Constants.OREGON:
                {
                    utility.WriteQuadrantMessage(firstNumber, secondNumber, quadrant);
                    break;
                }
            }
        }
    }
}