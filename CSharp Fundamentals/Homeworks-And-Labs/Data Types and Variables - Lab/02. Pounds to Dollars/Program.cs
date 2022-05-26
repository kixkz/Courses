using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pouds = double.Parse(Console.ReadLine());
            double usDolars = pouds * 1.31;

            Console.WriteLine($"{usDolars:f3}");
        }
    }
}
