using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main()
        {
            //string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            string names = Console.ReadLine();

            //MatchCollection matchedNames = Regex.Matches(names, regex);
            MatchCollection matchedNames = regex.Matches(names);

            foreach (Match name in matchedNames)
            {
                Console.Write($"{name.Value} ");
            }
        }
    }
}
