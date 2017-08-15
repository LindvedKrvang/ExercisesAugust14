using System;
using System.Text.RegularExpressions;

namespace August15
{
    public class Utility
    {
        /// <summary>
        /// Prompt the user for a number. Validates it and returns it.
        /// </summary>
        /// <returns></returns>
        public int PromptNumber()
        {
            int input;
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("");
                input = PromptNumber();
            }
            return input;
        }

        /// <summary>
        /// Prompts the user for two numbers.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        public void PromptNumbers(out int firstNumber, out int secondNumber)
        {
            Console.WriteLine("Please enter a number:");
            firstNumber = PromptNumber();
            Console.WriteLine("Please enter a second number:");
            secondNumber = PromptNumber();
        }

        /// <summary>
        /// Prompt the user for three numbers.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        public void PromptNumbers(out int firstNumber, out int secondNumber, out int thirdNumber)
        {
            PromptNumbers(out firstNumber, out secondNumber);
            Console.WriteLine("Please enter a third number;");
            thirdNumber = PromptNumber();
        }

        /// <summary>
        /// Prompt the user for a letter. Validates and returns it.
        /// </summary>
        /// <returns></returns>
        public string PromptLetter()
        {
            var input = Console.ReadLine();
            var regex = new Regex("[a-zA-Z]");
            if(string.IsNullOrWhiteSpace(input) || input.ToCharArray().Length > 1 || !regex.IsMatch(input))
            {
                Console.WriteLine("I can't use that. Try again:");
                input = PromptLetter();
            }
            return input;
        }

        /// <summary>
        /// Checks if the given string is a vowel.
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        public bool CheckIsVowel(string letter)
        {
            var regexVowel = new Regex("[aeyuio]");
            return regexVowel.IsMatch(letter);
        }

        /// <summary>
        /// Recieves an (x,y) coordinate and returns what quadrant they are in.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public EnumQuadrants FindQuadrant(int x, int y)
        {
            if (x < 0 && y < 0)
            {
                return EnumQuadrants.ThirdQuadrant;
            }
            else if (x > 0 && y < 0)
            {
                return EnumQuadrants.FourthQuadrant;
            }
            else if (x < 0 && y > 0)
            {
                return EnumQuadrants.SecondQuadrant;
            }
            else if (x > 0 && y > 0)
            {
                return EnumQuadrants.FirstQuadrant;
            }
            else
            {
                return EnumQuadrants.Oregon;
            }
        }

        /// <summary>
        /// Receives an (x,y) coordinate and returns what quadrant they are in.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public QuadrantsStruct FindQuadrantStruct(int x, int y)
        {
            var quadrant = new QuadrantsStruct();

            if (x < 0 && y < 0)
            {
                quadrant.quadrant = Constants.THIRD_QUADRANT;
                return quadrant;
            } else if (x > 0 && y < 0)
            {
                quadrant.quadrant = Constants.FOURTH_QUARDANT;
                return quadrant;
            } else if (x < 0 && y > 0)
            {
                quadrant.quadrant = Constants.SECOND_QUADRANT;
                return quadrant;
            } else if (x > 0 && y > 0)
            {
                quadrant.quadrant = Constants.FIRST_QUADRANT;
                return quadrant;
            } else
            {
                quadrant.quadrant = Constants.OREGON;
                return quadrant;
            }
        }

        /// <summary>
        /// Writes a message with the given information.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="enumQuadrant"></param>
        public void WriteQuadrantMessage(int x, int y, EnumQuadrants enumQuadrant)
        {
            Console.WriteLine($"The coordinate ({x},{y}) is in the {enumQuadrant.ToDescription()}.");
        }

        /// <summary>
        /// Writes a message with the given information.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="structQuadrant"></param>
        public void WriteQuadrantMessage(int x, int y, QuadrantsStruct structQuadrant)
        {
            Console.WriteLine($"The coordinate ({x},{y}) is in the {structQuadrant.quadrant}.");
        }
    }
}