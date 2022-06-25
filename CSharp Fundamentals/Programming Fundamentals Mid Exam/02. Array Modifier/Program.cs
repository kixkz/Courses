using System;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = String.Empty;
            
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "swap")
                {
                    int indexOne = int.Parse(command[1]);
                    int indexTwo = int.Parse(command[2]);
                    int tempElement = numbers[indexOne];
                    numbers[indexOne] = numbers[indexTwo];
                    numbers[indexTwo] = tempElement;
                }
                else if (command[0] == "multiply")
                {
                    int indexOne = int.Parse(command[1]);
                    int indexTwo = int.Parse(command[2]);
                    numbers[indexOne] *= numbers[indexTwo];
                }
                else if (command[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
