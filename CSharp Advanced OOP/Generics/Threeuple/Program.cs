using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] personInput = Console.ReadLine().Split(' ');
            string[] beerInput = Console.ReadLine().Split(' ');
            string[] numbersInput = Console.ReadLine().Split(' ');


            MyTuple<string, string, string> personInfo = new MyTuple<string, string, string>($"{personInput[0]} {personInput[1]}", personInput[2], personInput[3]);

            bool drunk = beerInput[2] == "drunk" ? true : false;

            MyTuple<string, int, bool> beerInfo = new MyTuple<string, int, bool>(beerInput[0], int.Parse(beerInput[1]), drunk);
            MyTuple<string, double, string> numbersInfo = new MyTuple<string, double, string>(numbersInput[0], double.Parse(numbersInput[1]), numbersInput[2]);

            Console.WriteLine(personInfo);
            Console.WriteLine(beerInfo);
            Console.WriteLine(numbersInfo);
        }
    }
}
