using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{GetRandomMessege(phrases)} {GetRandomMessege(events)} {GetRandomMessege(authors)} - {GetRandomMessege(cities)}");
            }
        }

        public static string GetRandomMessege(string[] array)
        {
            Random random = new Random();
            int index = random.Next(array.Length);
            return array[index];
        }
    }
}
