using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string string1 = input[0];
            string string2 = input[1];

            SumCharactersInStrings(string1, string2);
        }

        public static void SumCharactersInStrings(string string1, string string2)
        {
            double sum = 0;
            int mininumLength = Math.Min(string1.Length, string2.Length);
            for (int i = 0; i < mininumLength; i++)
            {
                sum += string1[i] * string2[i];
            }

            string longestLenghtString = string1;
            if (longestLenghtString.Length < string2.Length)
            {
                longestLenghtString = string2;
            }

            for (int i = mininumLength; i < longestLenghtString.Length; i++)
            {
                sum += longestLenghtString[i];
            }

            Console.WriteLine(sum);
        }
    }
}
