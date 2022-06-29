using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = String.Empty;
            int countMoves = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                countMoves++;
                int[] indexes = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int indexOne = indexes[0];
                int indexTwo = indexes[1];
                if (indexOne == indexTwo || indexOne < 0 || indexTwo < 0 || indexOne > elements.Count - 1 || indexTwo > elements.Count - 1)
                {
                    //string value = "-" + countMoves.ToString() + "a";
                    string value = $"-{countMoves}a";
                    elements.Insert(elements.Count / 2, value);
                    elements.Insert(elements.Count / 2, value);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (elements[indexOne] != elements[indexTwo])
                {
                    Console.WriteLine("Try again!");
                }
                else if (elements[indexOne] == elements[indexTwo])
                {
                    int maxIndex = Math.Max(indexOne, indexTwo);
                    int minIndex = Math.Min(indexOne, indexTwo);
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[indexOne]}!");
                    elements.RemoveAt(maxIndex);
                    elements.RemoveAt(minIndex);
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {countMoves} turns!");
                    return;
                }
            }

            if (elements.Count >=0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(' ', elements));
            }
        }
    }
}
