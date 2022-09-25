using System;
using Tuple;

namespace Tuplee
{
    internal class Program
    {
        static void Main()
        {
            string[] personInput = Console.ReadLine().Split(' ');
            string[] beerInput = Console.ReadLine().Split(' ');
            string[] numbersInput = Console.ReadLine().Split(' ');


            MyTuple<string, string> personInfo = new MyTuple<string, string>($"{personInput[0]} {personInput[1]}", personInput[2]);
            MyTuple<string, int> beerInfo = new MyTuple<string, int>(beerInput[0], int.Parse(beerInput[1]));
            MyTuple<int, double> numbersInfo = new MyTuple<int, double>(int.Parse(numbersInput[0]), double.Parse(numbersInput[1]));

            Console.WriteLine(personInfo);
            Console.WriteLine(beerInfo);
            Console.WriteLine(numbersInfo);
        }
    }
}
