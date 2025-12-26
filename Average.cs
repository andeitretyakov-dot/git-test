using System;
using System.Collections.Generic;

namespace project
{
    class Average
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 6, 1, 2, 10, 8 };
            numbers.Add(8);
            numbers.Remove(numbers[0]);
            numbers.Sort();
            

            foreach(int el in numbers) {
                Console.WriteLine("Numbers: " + el);
            }
        }
    }
}




