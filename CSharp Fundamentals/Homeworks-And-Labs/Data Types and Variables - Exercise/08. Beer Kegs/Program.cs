using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggest = int.MinValue;
            string biggestKeg = "";

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > biggest)
                {
                    biggestKeg = model;
                    biggest = volume;
                }
            }

            Console.WriteLine(biggestKeg);

        }
    }
}
