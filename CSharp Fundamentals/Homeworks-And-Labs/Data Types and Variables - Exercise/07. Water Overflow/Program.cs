using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int tankCapacity = 255;

            for (int i = 1; i <= lines; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                if (litres > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tankCapacity -= litres;
                }
            }

            Console.WriteLine(255 - tankCapacity);
        }
    }
}
