using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                switch (action)
                {
                    case "Urgent":
                        if (!products.Contains(command[1]))
                        {
                            products.Insert(0, command[1]);
                        }
                        break;
                    case "Unnecessary":
                        if (products.Contains(command[1]))
                        {
                            products.Remove(command[1]);
                        }
                        break;
                    case "Correct":
                        if (products.Contains(command[1]))
                        {
                            int index = products.IndexOf(command[1]);
                            products.Insert(index, command[2]);
                            products.Remove(command[1]);
                        }
                        break;
                    case "Rearrange":
                        if (products.Contains(command[1]))
                        {
                            products.Remove(command[1]);
                            products.Add(command[1]);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", products));
        }
    }
}
