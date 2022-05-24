using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int day = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                double currentSum = (day * capsuleCount) * capsulePrice;
                Console.WriteLine($"The price for the coffee is: ${currentSum:f2}");

                sum += currentSum;
            }

            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}
