﻿using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int aggregate = num1 + num2;
            int divide = aggregate / num3;
            int multiply = divide * num4;

            Console.WriteLine(multiply);
        }
    }
}
