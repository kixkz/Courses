using System;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            char previousChar = str[0];
            Console.Write(previousChar);

            for (int i = 1; i < str.Length; i++)
            {
                char currentChar = str[i];
                if (previousChar != currentChar)
                {
                    previousChar = currentChar;
                    Console.Write(previousChar);
                }
            }
        }
    }
}
