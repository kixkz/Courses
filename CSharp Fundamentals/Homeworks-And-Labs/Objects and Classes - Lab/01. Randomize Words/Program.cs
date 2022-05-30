using System;
using System.Linq;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int newPosition = rnd.Next(array.Length);
                string temp = array[i];
                array[i] = array[newPosition];
                array[newPosition] = temp;
            }

            Console.WriteLine(string.Join("\n", array));
        }
    }
}
