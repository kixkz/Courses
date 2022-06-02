using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nummbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < nummbers.Length; i++)
            {
                if (nummbers[i] % 2 == 0)
                {
                    sum += nummbers[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
