using System;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int digit = int.Parse(Console.ReadLine());
            StringBuilder output = new StringBuilder();
            int keepInMind = 0;

            if (digit == 0 || num == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = num.Length - 1; i >= 0; i--)
            {
                int currDigit = int.Parse(num[i].ToString());
                int currSum = currDigit * digit + keepInMind;
                keepInMind = currSum / 10;
                int result = currSum % 10;
                output.Insert(0, result);
            }

            if (keepInMind > 0)
            {
                output.Insert(0, keepInMind);
            }
            
            Console.WriteLine(output.ToString());
        }
    }
}
