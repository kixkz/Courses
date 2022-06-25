using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(' ');
                
                if (arguments[0] == "Shoot")
                {
                    int index = int.Parse(arguments[1]);
                    int power = int.Parse(arguments[2]);
                    Shoot(index, power, targets);
                }
                else if (arguments[0] == "Add")
                {
                    int index = int.Parse(arguments[1]);
                    int value = int.Parse(arguments[2]);
                    Add(index, value, targets);
                }
                else if (arguments[0] == "Strike")
                {
                    int index = int.Parse(arguments[1]);
                    int radius = int.Parse(arguments[2]);
                    Strike(index, radius, targets);
                }
            }

            Console.WriteLine(string.Join('|', targets));
        }

        static void Shoot(int index, int power, List<int> targets)
        {
            if (index >= 0 && index < targets.Count)
            {
                if (power >= targets[index])
                {
                    targets.RemoveAt(index);
                }
                else
                {
                    targets[index] -= power;
                }
            }
        }

        static void Add(int index, int value, List<int> targets)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        static void Strike(int index, int radius, List<int> targets)
        {
            if (index < 0 || index > targets.Count - 1 || index - radius < 0 || index + radius > targets.Count - 1)
            {
                Console.WriteLine("Strike missed!");
                return;
            }
            else
            {
                targets.RemoveRange(index - radius, radius * 2 + 1);
            }
        }
    }
}
