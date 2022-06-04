using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] newArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (i % 2 != 0)
                {
                    arr2[i] = newArray[0];
                    arr1[i] = newArray[1];
                }
                else
                {
                    arr2[i] = newArray[1];
                    arr1[i] = newArray[0];
                }
            }

            Console.WriteLine(string.Join(' ', arr1));
            Console.WriteLine(string.Join(' ', arr2));
            
        }
    }
}
