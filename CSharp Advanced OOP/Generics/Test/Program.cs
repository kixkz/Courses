using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
    }

    public class Cat : BaseEntity<int>
    {

    }

    public class CustomTuple<T1, T2>
    {
        public CustomTuple(T1 first, T2 second)
        {
            Item1 = first;
            Item2 = second;
        }

        public T1 Item1 { get; set; }

        public T2 Item2 { get; set; }

        public int Count { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = CreateArray<int>(3, 1);
            var strings = CreateArray<string>(3, "Hello");
            var chars = CreateArray<char>(3, 'a');
            var doubles = CreateArray<double>(3, 2.4);
            Cat[] cats = CreateArray<Cat>(3, new Cat());

            CustomTuple<int, string> customTuple = new CustomTuple<int, string>(1, "string");
            Console.WriteLine(customTuple.Item1);
            Console.WriteLine(customTuple.Item2);
        }

        public static T[] CreateArray<T>(int count, T item)
        {
            var array = new T[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = item;
            }

            return array;
        }

        //public static int[] CreateArray(int count, int item)
        //{
        //    int[] array = new int[count];
        //    for (int i = 0; i < count; i++)
        //    {
        //        array[i] = item;
        //    }

        //    return array;
        //}

        //public static string[] CreateArray(int count, string item)
        //{
        //    string[] array = new string[count];
        //    for (int i = 0; i < count; i++)
        //    {
        //        array[i] = item;
        //    }

        //    return array;
        //}
    }
}
