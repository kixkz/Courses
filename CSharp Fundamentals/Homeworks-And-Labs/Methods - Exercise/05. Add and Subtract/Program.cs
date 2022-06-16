using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractNumbers(num1, num2, num3));
        }

        static int SumTwoNumbers(int a, int b)
        {
            return a + b;
        }

        static int SubtractNumbers(int a, int b, int c)
        {
            return SumTwoNumbers(a, b) - c;
        }
    }
}
