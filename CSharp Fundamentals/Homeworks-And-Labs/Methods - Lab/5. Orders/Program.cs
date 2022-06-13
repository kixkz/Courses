using System;

namespace _5._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculatePrice(product, quantity);
        }

        static void CalculatePrice(string product, int quantity)
        {
            if (product == "coffee")
            {
                Console.WriteLine($"{1.50 * quantity:f2}");
            }
            else if (product == "water")
            {
                Console.WriteLine($"{1.00 * quantity:f2}");
            }
            else if (product == "coke")
            {
                Console.WriteLine($"{1.40 * quantity:f2}");
            }
            else if (product == "snacks")
            {
                Console.WriteLine($"{2.00 * quantity:f2}");
            }
        }
    }
}
