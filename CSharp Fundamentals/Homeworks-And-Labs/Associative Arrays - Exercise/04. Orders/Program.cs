using System;
using System.Collections.Generic;

namespace _04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> orders = new Dictionary<string, double>();
            Dictionary<string, int> newOrders = new Dictionary<string, int>();
            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string product = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (!orders.ContainsKey(product))
                {
                    orders[product] = price;
                    newOrders[product] = quantity;
                }
                else
                {
                    orders[product] = price;
                    newOrders[product] += quantity;
                }
            }

            foreach (var order in orders)
            {
                foreach (var newOrder in newOrders) 
                {
                    if (order.Key == newOrder.Key)
                    {
                        Console.WriteLine($"{order.Key} -> {order.Value * newOrder.Value:f2}");
                    }    
                }
            }
        }
    }
}
