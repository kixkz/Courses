using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] dna = new int[n];

            int bestLength = 1;
            int bestStartIndex = 0;
            int bestDnaSum = 0;
            int dnaCounter = 0;
            int bestDnaCounter = 0;

            while (input != "Clone them!")
            {
                int[] currentDNA = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                dnaCounter++;

                int length = 1;
                int currentBestLength = 1;
                int startIndex = 0;
                int currentDnaSum = 0;

                for (int i = 0; i < currentDNA.Length - 1; i++)
                {
                    if (currentDNA[i] == currentDNA[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }

                    if (length > currentBestLength)
                    {
                        currentBestLength = length;
                        startIndex = i;
                    }

                    currentDnaSum += currentDNA[i];
                }

                currentDnaSum += currentDNA[n - 1];

                if (currentBestLength > bestLength)
                {
                    bestLength = currentBestLength;
                    bestStartIndex = startIndex;
                    bestDnaSum = currentDnaSum;
                    bestDnaCounter = dnaCounter;
                    dna = currentDNA.ToArray();
                }
                else if (currentBestLength == bestLength)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLength = currentBestLength;
                        bestStartIndex = startIndex;
                        bestDnaSum = currentDnaSum;
                        bestDnaCounter = dnaCounter;
                        dna = currentDNA.ToArray();
                    }
                    else if (currentDnaSum > bestDnaSum)
                    {
                        bestLength = currentBestLength;
                        bestStartIndex = startIndex;
                        bestDnaSum = currentDnaSum;
                        bestDnaCounter = dnaCounter;
                        dna = currentDNA.ToArray();
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestDnaCounter} with sum: {bestDnaSum}.");
            Console.WriteLine(string.Join(' ', dna));
        }
    }
}
