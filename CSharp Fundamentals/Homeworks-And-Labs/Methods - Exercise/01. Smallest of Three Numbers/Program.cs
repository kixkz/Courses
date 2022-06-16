using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int result = GetSmallestNumber(numOne, GetSmallestNumber(numTwo, numThree));

            Console.WriteLine(result);
        }

        static int GetSmallestNumber(int numOne, int numTwo)
        {
            if (numOne < numTwo)
            {
                return numOne;
            }
            else
            {
                return numTwo;
            }
        }
    }
}
