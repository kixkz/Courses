using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nummbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < nummbers.Length; i++)
            {
                if (nummbers[i] % 2 == 0)
                {
                    evenSum += nummbers[i];
                }
                else
                {
                    oddSum += nummbers[i];
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
