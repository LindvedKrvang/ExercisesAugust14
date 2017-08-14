using System;

namespace August14_2
{
    public class Utility
    {
        /// <summary>
        /// Prompts the user for some text.
        /// </summary>
        /// <returns></returns>
        public string PromptText()
        {
            var text = Console.ReadLine();
            while (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("I can't use that. Please write something:");
                text = Console.ReadLine();
            }
            return text;
        }

        /// <summary>
        /// Prompts for a number. Validates it and returns it.
        /// </summary>
        /// <returns></returns>
        public int PromptNumber()
        {
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("That's not a valid number. Try again:");
                number = PromptNumber();
            }
            return number;
        }
    }
}