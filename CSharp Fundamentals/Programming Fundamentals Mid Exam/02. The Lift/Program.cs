using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonMaxCount = 4;

            for (int i = 0; i < wagons.Count; i++)
            {
                for (int j = wagons[i]; j < wagonMaxCount; j++)
                {
                    wagons[i]++;
                    peopleCount--;
                    if (peopleCount == 0)
                    {
                        if (wagons.Sum() < wagons.Count * wagonMaxCount)
                        {
                            Console.WriteLine("The lift has empty spots!");
                        }

                        Console.WriteLine(string.Join(' ', wagons));
                        return;
                    }
                }
            }
            
            Console.WriteLine($"There isn't enough space! {peopleCount} people in a queue!");
            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
