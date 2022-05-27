using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int daysCount = 0;
            int spicesMined = 0;
            int spicesConsumed = 0;
            int spicesStored = 0;


            for (int i = n; i >= 100; i -= 10)
            {
                spicesMined += i;
                spicesStored = spicesMined;
                spicesConsumed += 26;
                spicesStored -= spicesConsumed;
                daysCount++;
            }

            if (spicesStored < 26)
            {
                spicesConsumed = spicesStored;
                spicesStored = 0;
            }
            else
            {
                spicesConsumed += 26;
                spicesStored -= 26;
            }

            Console.WriteLine(daysCount);
            Console.WriteLine(spicesStored);
        }
    }
}
