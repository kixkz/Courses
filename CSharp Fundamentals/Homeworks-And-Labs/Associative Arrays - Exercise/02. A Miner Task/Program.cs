using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            string resourse;
            while ((resourse = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!resourses.ContainsKey(resourse))
                {
                    resourses[resourse] = 0;
                }
                
                resourses[resourse] += quantity;
            }
        
            foreach (var resuorse in resourses)
            {
                Console.WriteLine($"{resuorse.Key} -> {resuorse.Value}");
            }
        }
    }
}
