using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Deck_of_Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                if (command == "Add")
                {
                    if (cards.Contains(tokens[1]))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        cards.Add(tokens[1]);
                        Console.WriteLine("Card successfully added");
                    }
                }
                else if (command == "Remove")
                {
                    if (!cards.Contains(tokens[1]))
                    {
                        Console.WriteLine("Card not found");
                    }
                    else
                    {
                        cards.Remove(tokens[1]);
                        Console.WriteLine("Card successfully removed");
                    }
                }
                else if (command == "Remove At")
                {
                    int index = int.Parse(tokens[1]);
                    if (index < 0 || index > cards.Count - 1)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        cards.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    if (index < 0 || index > cards.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        if (cards.Contains(tokens[2]))
                        {
                            Console.WriteLine("Card is already added");
                        }
                        else
                        {
                            cards.Insert(index, tokens[2]);
                            Console.WriteLine("Card successfully added");
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(", ", cards));
        }
    }
}
