using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int counter = 1;
            int tempCounter = 1;
            int number = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    tempCounter++;
                }
                else
                {
                    tempCounter = 1;
                }

                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    number = array[i];
                }
            }

            for (int i = 0; i < counter; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
