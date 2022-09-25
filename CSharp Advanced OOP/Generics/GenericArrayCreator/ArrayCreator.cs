
using System.Runtime.InteropServices.ComTypes;

namespace GenericArrayCreator
{
    public static class ArrayCreator
    {
        public static T[] Create<T>(int count, T item)
        {
            var array = new T[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = item;
            }

            return array;
        }

        //public static int[] Create(int count, int item)
        //{
        //    var array = new int[count];
        //    for (int i = 0; i < count; i++)
        //    {
        //        array[i] = item;
        //    }

        //    return array;
        //}
    }
}
