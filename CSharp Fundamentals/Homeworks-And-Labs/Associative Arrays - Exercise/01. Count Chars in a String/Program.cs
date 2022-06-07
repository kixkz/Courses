using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (char ch in input)
            {
                if (result.ContainsKey(ch))
                {
                    result[ch]++;
                }
                else
                {
                    result.Add(ch, 1);
                }
            }

            foreach (var item in result.Where(item => item.Key != ' '))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
