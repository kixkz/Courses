using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            for (int num = 1; num <= numbersCount; num++)
            {
                int currentNum = num;
                int sum = 0;
                while (currentNum != 0)
                {
                    sum += currentNum % 10;
                    currentNum /= 10;
                }

                bool isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", num, isSpecialNum);
            }
        }
    }
}
