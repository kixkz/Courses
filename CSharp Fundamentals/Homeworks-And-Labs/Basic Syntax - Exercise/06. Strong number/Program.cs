using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            char[] chars = input.ToString().ToCharArray();
            double sum = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                int tempSum = 1;
                int tempNumber = (int)(chars[i]) - 48;
                for (int j = tempNumber; j >= 1; j--)
                {
                    tempSum *= j;
                }

                sum += tempSum;
            }

            if (sum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
