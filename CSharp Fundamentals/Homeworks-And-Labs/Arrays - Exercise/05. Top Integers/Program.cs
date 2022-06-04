using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currentNum <= array[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
