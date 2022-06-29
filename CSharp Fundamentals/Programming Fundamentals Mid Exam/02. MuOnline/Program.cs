using System;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int bitcoins = 0;
            string[] rooms = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] tokens = rooms[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "potion")
                {
                    int currentHealth = initialHealth;
                    initialHealth += int.Parse(tokens[1]);
                    if (initialHealth > 100)
                    {
                        int healed = 100 - currentHealth;
                        Console.WriteLine($"You healed for {healed} hp.");
                        initialHealth = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {tokens[1]} hp.");
                    }
                    
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if (tokens[0] == "chest")
                {
                    Console.WriteLine($"You found {tokens[1]} bitcoins.");
                    bitcoins += int.Parse(tokens[1]);
                }
                else
                {
                    string monster = tokens[0];
                    int attackPower = int.Parse(tokens[1]);
                    initialHealth -= attackPower;
                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else if (initialHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}
