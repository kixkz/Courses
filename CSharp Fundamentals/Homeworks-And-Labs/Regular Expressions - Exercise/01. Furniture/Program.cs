using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main()
        {
            string input;
            string regex = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+\.?([0-9]+)?)!(?<quantity>\d+)";
            List<string> furnitureList = new List<string>();
            double sum = 0;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match matches = Regex.Match(input, regex, RegexOptions.IgnoreCase);
                if (matches.Success)
                {
                    string name = matches.Groups["name"].Value;
                    double price = double.Parse(matches.Groups["price"].Value);
                    int quantity = int.Parse(matches.Groups["quantity"].Value);

                    furnitureList.Add(name);
                    sum += quantity * price;
                } 
            }

            Console.WriteLine("Bought furniture:");
            foreach (var furniture in furnitureList)
            {
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
