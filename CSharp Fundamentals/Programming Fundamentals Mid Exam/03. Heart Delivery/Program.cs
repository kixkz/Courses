using System;
using System.Linq;
using System.Threading.Channels;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = String.Empty;
            int lastPosition = 0;

            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int index = int.Parse(commands[1]);
                lastPosition += index;
                if (lastPosition > houses.Length - 1)
                {
                    lastPosition = 0;
                }
                if (houses[lastPosition] == 0)
                {
                    Console.WriteLine($"Place {lastPosition} already had Valentine's day.");
                }
                else
                {
                    houses[lastPosition] -= 2;
                    if (houses[lastPosition] == 0)
                    {
                        Console.WriteLine($"Place {lastPosition} has Valentine's day.");
                    }
                }
            }

            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            bool isSuccessfull = true;
            int counter = 0;
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i] != 0)
                {
                    isSuccessfull = false;
                    counter++;
                }
            }

            if (isSuccessfull)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
        }
    }
}
