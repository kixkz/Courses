using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool isFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                for (int j = array.Length - 1; j > i; j--)
                {
                    leftSum += array[j];
                }

                int rightSum = 0;
                for (int c = 0; c < i; c++)
                {
                    rightSum += array[c];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            } 
        }
    }
}
