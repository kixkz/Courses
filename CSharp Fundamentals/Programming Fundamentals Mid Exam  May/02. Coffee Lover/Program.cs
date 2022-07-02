using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine().Split().ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                if (command == "Include")
                {
                    coffees.Add(tokens[1]);
                }
                else if (command == "Remove")
                {
                    string firstOrLast = tokens[1];
                    int numbers = int.Parse(tokens[2]);
                    if (coffees.Count >= numbers)
                    {
                        for (int j = 1; j <= numbers; j++)
                        {
                            if (firstOrLast == "first")
                            {
                                coffees.RemoveAt(0);
                            }
                            else
                            {
                                coffees.RemoveAt(coffees.Count - 1);
                            }
                        }
                    }
                }
                else if (command == "Prefer")
                {
                    int indexOne = int.Parse(tokens[1]);
                    int indexTwo = int.Parse(tokens[2]);
                    if (indexOne >= 0 && indexTwo >= 0 && indexOne < coffees.Count && indexTwo < coffees.Count)
                    {
                        string temp = coffees[indexOne];
                        coffees[indexOne] = coffees[indexTwo];
                        coffees[indexTwo] = temp;
                    }
                }
                else if (command == "Reverse")
                {
                    coffees.Reverse();
                }
            }

            Console.WriteLine($"Coffees:\n {string.Join(' ', coffees)}");
        }
    }
}
