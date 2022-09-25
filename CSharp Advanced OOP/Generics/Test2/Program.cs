using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<int>();
            
            box.Add(1);
            Console.WriteLine(box.Count);
            box.Remove();
            Console.WriteLine(box.Count);

            Console.WriteLine("--------------------");

            Box<string> stringBox = new Box<string>();

            stringBox.Add("Emo");
            stringBox.Add("Iva");
            Console.WriteLine(stringBox.Count);
            stringBox.Remove();
            Console.WriteLine(stringBox.Count);
        }
    }
}
