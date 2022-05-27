﻿using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                int tempNumber = number % 10;
                number /= 10;
                sum += tempNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
