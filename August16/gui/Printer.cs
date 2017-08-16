using System;
using System.Collections.Generic;
using System.Text;

namespace August16.gui
{
    class Printer
    {
        /// <summary>
        /// Prints the given list on a single line, divided by ", "
        /// </summary>
        /// <param name="list"></param>
        public void PrintListOfNumbers(List<int> list) {
            foreach (var item in list) {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Printes the give HashSet on a single line.
        /// </summary>
        /// <param name="set"></param>
        public void PrintSetOfNumbers(HashSet<int> set)
        {
            if (set == null || set.Count == 0)
            {
                Console.WriteLine("There is nothing to display!");
                return;
            }

            foreach (var item in set)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
