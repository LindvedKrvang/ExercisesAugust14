using System;
using System.Collections.Generic;
using System.Text;

namespace August16.bll
{
    class Utility
    {
        /// <summary>
        /// Gets a single number from the user.
        /// </summary>
        /// <returns></returns>
        public int PromptNumber()
        {
            int input;
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("That's not a valid number. Try again:");
                input = PromptNumber();
            }
            return input;
        }
        
        /// <summary>
        /// Gets a List of numbers from the user. The Count of the list equals the parsed parameter.
        /// </summary>
        /// <param name="amountOfNumbers"></param>
        /// <returns></returns>
        public List<int> GetListOfNumbers(int amountOfNumbers) {
            Console.WriteLine($"Please enter {amountOfNumbers} numbers:");
            var numbers = new List<int>();
            for (int i = 0; i < amountOfNumbers; i++) {
                numbers.Add(PromptNumber());
            }
            Console.WriteLine();
            return numbers;
        }

        /// <summary>
        /// Takes a List of integers and returns the sum.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int GetSumOfNumbers(List<int> numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        
    }
}
