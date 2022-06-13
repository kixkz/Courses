using System;

namespace Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeated = RepeatString(Console.ReadLine(), int.Parse(Console.ReadLine()));

            Console.WriteLine(repeated);
        }

        static string RepeatString(string input, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += input;
            }

            return result;
        }
    }
}
