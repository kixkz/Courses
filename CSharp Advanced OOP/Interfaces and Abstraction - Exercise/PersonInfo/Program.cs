﻿using System;
using PersonInfo.Interfaces;
using PersonInfo.Models;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();

            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthhable = new Citizen(name, age, id, birthdate);

            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthhable.BirthDate);
        }
    }
}
