using System;

namespace _4._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintTriangleLine(i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                PrintTriangleLine(i);
            }
        }

        static void PrintTriangleLine(int line)
        {
            for (int j = 1; j <= line; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}
