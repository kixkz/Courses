﻿using System;

namespace _3._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            switch (comand)
            {
                case "add":
                    Add(number1, number2);
                    break;
                case "subtract":
                    Subtract(number1, number2);
                    break;
                case "multiply":
                    Multiply(number1, number2);
                    break;
                case "divide":
                    Divide(number1, number2);
                    break;
            }
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
