using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        
        /// <summary>
        /// Recieves a List of Integers and returns a Set of Integers containing all the duplicates.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public HashSet<int> GetDuplicatesInList(List<int> list)
        {
            var set = new HashSet<int>();
            var duplicates = new HashSet<int>();

            foreach (var item in list)
            {
                if (!set.Add(item))
                {
                    duplicates.Add(item);
                }
            }
            return duplicates;
        }
        
        /// <summary>
        /// Recieves a List of Integers and returns a set with all the unique numbers in the list.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<int> GetUniqueElementsInAList(List<int> list)
        {

            List<int> uniqueNumbers = list.GroupBy(i => i)
                .Where(g => g.Count() == 1)
                .Select(g => g.Key)
                .ToList();
            return uniqueNumbers;
        }

        /// <summary>
        /// Recieves X lists, adds them, sorts them and returns them.
        /// </summary>
        /// <param name="lists"></param>
        /// <returns></returns>
        public List<int> MergeAndSortList(params List<int>[] lists)
        {
            if(lists == null) { throw new NullReferenceException("There needs to be something parsed!");}

            var list = new List<int>();
            foreach (var item in lists)
            {
                list.AddRange(item);
            }
            list.Sort();
            return list;
        }

        /// <summary>
        /// Takes a List of Integers and find the frequency of each Integer.
        /// Returns them in a Dictionary.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetFrequency(List<int> list)
        {
            var frequency = new Dictionary<int, int>();

            foreach (var item in list)
            {
                if (frequency.TryGetValue(item, out int value))
                {
                    value++;
                    frequency[item] = value;
                }
                else
                {
                    frequency[item] = 1;
                }
            }
            return frequency;
        }
    }
}
