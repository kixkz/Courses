using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char ch = char.Parse(Console.ReadLine());   
                int number = (int)ch;
                sum += number;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
