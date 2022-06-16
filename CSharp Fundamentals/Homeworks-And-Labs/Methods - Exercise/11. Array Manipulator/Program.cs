using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int splitIndex = int.Parse(tokens[1]);
                if (command == "exchange")
                {
                    numbers = SplitArray(numbers, splitIndex);
                    //Console.WriteLine(string.Join(' ', numbers));
                }
                else if (tokens[0] == "max" || tokens[0] == "min")
                {
                    FindMinMax(numbers, command[0], command[1]);
                }

                input = Console.ReadLine();
            }
            
        }

        private static void FindMinMax(int[] numbers, char minOrMax, char evenOrOdd)
        {
             
        }

        static int[] SplitArray(int[] array, int splitIndex)
        {
            if (splitIndex >= array.Length || splitIndex < 0)
            {
                Console.WriteLine("Invalid index");
            }
            
            for (int i = 0; i < splitIndex; i++)
            {
                int lastElement = array[array.Length - 1];
                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = lastElement;
            }

            return array;
        }
    }
}
