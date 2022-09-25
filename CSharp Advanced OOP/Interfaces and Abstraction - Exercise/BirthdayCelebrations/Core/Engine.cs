﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BirthdayCelebrations.Contracts;
using BirthdayCelebrations.Models;
using BorderControl.Contracts;
using BorderControl.Models;

namespace BorderControl.Core
{
    public class Engine
    {
        private List<IBirthable> repository;

        public Engine()
        {
            this.repository = new List<IBirthable>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputTokens = input.Split().ToArray();

                CreateBirthable(inputTokens);

                input = Console.ReadLine();
            }

            string searhYear = Console.ReadLine();
            string[] birthdates = this.repository.Where(b => b.Birthdate.Split("/").Last() == searhYear)
                .Select(b => b.Birthdate).ToArray();

            PrintFinalResult(birthdates);
        }

        private void PrintFinalResult(string[] birthdates)
        {
            foreach (var birthdate in birthdates)
            {
                Console.WriteLine(birthdate);
            }
        }

        private void CreateBirthable(string[] inputTokens)
        {
            IBirthable birthable = null;
            var type = inputTokens[0];
            if (type == "Citizen")
            {
                string name = inputTokens[1];
                int age = int.Parse(inputTokens[2]);
                string id = inputTokens[3];
                string birthdate = inputTokens[4];

                birthable = new Citizen(id, name, age, birthdate);
            }
            else if(type == "Pet")
            {
                string name = inputTokens[1];
                string birthdate = inputTokens[2];

                birthable = new Pet(name, birthdate);
            }

            if (birthable != null)
            {
                this.repository.Add(birthable);
            }

            
        }
    }
}
