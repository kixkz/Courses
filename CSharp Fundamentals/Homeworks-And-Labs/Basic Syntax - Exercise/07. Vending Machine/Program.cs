using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string command;

            while ((command = Console.ReadLine()) != "Start")
            {
                if (command == "0.1" || command == "0.2" || command == "0.5" || command == "1" || command == "2")
                {
                    sum += double.Parse(command);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {command}");
                }
            }

            string product = Console.ReadLine();
            double price = 0;

            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Coke":
                        price = 1;
                        break;
                    case "Soda":
                        price = 0.80;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                }

                if (sum >= price)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sum -= price;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
