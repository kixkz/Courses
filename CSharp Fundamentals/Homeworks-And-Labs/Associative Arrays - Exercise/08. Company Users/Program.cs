using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = tokens[0];
                string employeeId = tokens[1];
                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>(){employeeId});
                }
                else
                {
                    if (!companies[companyName].Contains(employeeId))
                    {
                        companies[companyName].Add(employeeId);
                    }
                    
                }
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (var item in company.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
