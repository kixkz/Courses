using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            CountVowels(input);
        }

        static void CountVowels(string text)
        {
            Console.WriteLine(text.Count(vowels => "aeiou".Contains(vowels)));
        }

        //private static int CountVowels(string input)
        //{
        //    int count = 0;
        //    foreach (char ch in input)
        //    {
        //        if ("aeiou".Contains(ch))
        //        {
        //            count++;
        //        }
        //    }

        //    return count;
        //}
    }
}
