using System;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main()
        {
            string word;

            while ((word = Console.ReadLine()) != "end")
            {
                char[] chars = word.ToCharArray();
                Array.Reverse(chars);
                string reversed = new string(chars);
                Console.WriteLine($"{word} = {reversed}");
            }
        }
    }
}
