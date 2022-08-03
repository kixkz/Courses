﻿using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main()
        {
            MatchCollection matches = Regex.Matches(Console.ReadLine(), @"\b(?<day>\d{2})(?<separator>[-\.\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})\b");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}
