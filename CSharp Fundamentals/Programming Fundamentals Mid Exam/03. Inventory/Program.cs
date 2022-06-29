using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] tokens = input.Split('-', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0].Trim();
                string item = tokens[1].Trim();

                if (command == "Collect")
                {
                    if (!items.Contains(item))
                    {
                        items.Add(item);
                    }
                }
                else if (command == "Drop")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }
                }
                else if (command == "Combine Items")
                {
                    string[] newItems = item.Split(':');
                    string oldItem = newItems[0];
                    string newItem = newItems[1];
                    if (items.Contains(oldItem))
                    {
                        int index = items.IndexOf(oldItem);
                        items.Insert(index + 1, newItem);
                    }
                }
                else if (command == "Renew")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
