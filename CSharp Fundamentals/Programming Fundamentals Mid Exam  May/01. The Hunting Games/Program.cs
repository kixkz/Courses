using System;

namespace _01._The_Hunting_Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double groupWater = water * numberOfPlayers * days;
            double groupFood = food * numberOfPlayers * days;

            for (int i = 1; i <= days; i++)
            {
                double energyLost = double.Parse(Console.ReadLine());
                energy -= energyLost;
                if (energy <= 0)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    energy += energy * 0.05;
                    groupWater -= groupWater * 0.30;
                }

                if (i % 3 == 0)
                {
                    groupFood -= groupFood / numberOfPlayers;
                    energy += energy * 0.10;
                }
            }

            if (energy <= 0)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {groupFood:f2} food and {groupWater:f2} water.");
            }
            else
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
        }
    }
}
