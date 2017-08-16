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
    }
}
