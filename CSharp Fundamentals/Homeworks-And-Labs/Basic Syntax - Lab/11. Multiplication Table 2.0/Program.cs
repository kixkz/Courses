using System;

namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            if (startNumber > 10)
            {
                sum = n * startNumber;
                Console.WriteLine($"{n} X {startNumber} = {sum}");
            }

            for (int i = startNumber; i <= 10; i++)
            {
                sum = n * i;
                Console.WriteLine($"{n} X {i} = {sum}");
            }
        }
    }
}
