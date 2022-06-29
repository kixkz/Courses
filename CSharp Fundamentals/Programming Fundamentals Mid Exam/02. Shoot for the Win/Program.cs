using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = String.Empty;
            int counter = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);
                if (index < 0 || index > targets.Length - 1)
                {
                    continue;
                }
                else
                {
                    counter++;
                    int temp = targets[index];
                    targets[index] = -1;
                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] >= 0 && targets[i] > temp)
                        {
                            targets[i] -= temp;
                        }
                        else if (targets[i] >= 0 && targets[i] <= temp)
                        {
                            targets[i] += temp;
                        }
                    }
                } 
            }

            Console.WriteLine($"Shot targets: {counter} -> {string.Join(' ', targets)}");
        }
    }
}
