using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericBoxOfString;

namespace GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(1.CompareTo(1)); //0
            //Console.WriteLine(1.CompareTo(2)); //-1
            //Console.WriteLine(2.CompareTo(1)); //1


            int integerValue = int.Parse(Console.ReadLine());

            var box = new Box<string>();

            for (int i = 0; i < integerValue; i++)
            {
                string stringValue = Console.ReadLine();
                box.Items.Add(stringValue);
            }

            string comparingItem = Console.ReadLine();
            int value = box.CountGreaterThan(comparingItem);

            Console.WriteLine(value);

            //int[] positions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //box.Swap(positions[0], positions[1]);

            Console.WriteLine(box);


            //var box = new Box<string>();
            //box.Items.Add("test");
            //box.Items.Add("test");
            //Console.WriteLine(box);
        }
    }
}
