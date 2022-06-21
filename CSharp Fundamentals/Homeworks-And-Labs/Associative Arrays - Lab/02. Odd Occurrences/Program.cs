﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> occurencies = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string lowerCaseWord = word.ToLower();
                if (occurencies.ContainsKey(lowerCaseWord))
                {
                    occurencies[lowerCaseWord]++;
                }
                else
                {
                    occurencies.Add(lowerCaseWord, 1); 
                }
            }

            string[] result = occurencies
                .Where(word => word.Value % 2 != 0)
                .Select(item => item.Key)
                .ToArray();

            Console.WriteLine(string.Join(" ", result));

            //foreach (var item in occurencies)
            //{
            //    if (item.Value % 2 != 0)
            //    {
            //        Console.Write($"{item.Key} ");
            //    }
            //}
        }
    }
}
