using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            CalculatePrice(input);
        }

        static void CalculatePrice(string input)
        {
            double price = 0;
            double taxes = 0;

            while (input != "special" || input != "regular")
            {
                if (input == "special" || input == "regular")
                {
                    var totalPrice = price + taxes;
                    if (totalPrice == 0)
                    {
                        Console.WriteLine("Invalid order!");
                        return;
                    }
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {price:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    if (input == "regular")
                    {
                        Console.WriteLine($"Total price: {totalPrice:f2}$");
                        break;
                    }
                    else
                    {
                        double discount = totalPrice * 0.10;
                        Console.WriteLine($"Total price: {totalPrice - discount:f2}$");
                        break;
                    }
                }
                else
                {
                    double currentPrice = double.Parse(input);
                    if (currentPrice < 0)
                    {
                        Console.WriteLine("Invalid price!");
                    }
                    else
                    {
                        price += currentPrice;
                        taxes += currentPrice * 0.20;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
