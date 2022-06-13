using System;

namespace _6._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(CalcRectangleArae(a, b));
        }

        static double CalcRectangleArae(double a, double b)
        {
            double area = a * b;
            return area;
        }
    }
}
