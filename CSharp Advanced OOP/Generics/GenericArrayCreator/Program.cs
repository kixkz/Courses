using System;

namespace GenericArrayCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringArray = ArrayCreator.Create(3, "Toshko");
            var intArray = ArrayCreator.Create(3, 4);
            var charArray = ArrayCreator.Create<char>(3, 'a');

            foreach (var s in stringArray)
            {
                Console.WriteLine(s);
            }

            foreach (var s in intArray)
            {
                Console.WriteLine(s);
            }

            foreach (var s in charArray)
            {
                Console.WriteLine(s);
            }
        }
    }
}
