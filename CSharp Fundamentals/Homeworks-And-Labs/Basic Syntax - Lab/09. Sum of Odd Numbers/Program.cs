using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            int counter = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    counter++;
                }

                if (counter == n)
                {
                    Console.WriteLine($"Sum: {sum}");
                    break;
                }    
            } 
        }
    }
}
