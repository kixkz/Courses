using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            string[] reversed = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - 1 - i];
            }
            
            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
