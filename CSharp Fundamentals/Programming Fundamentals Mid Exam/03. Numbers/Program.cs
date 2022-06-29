using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            double average = numbers.Average();

            List<int> sortedNums = numbers.OrderByDescending(x => x).Where(x => x > average).Take(5).ToList();
            
            if (sortedNums.Count <= 1)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine(string.Join(' ', sortedNums));
        }
    }
}
