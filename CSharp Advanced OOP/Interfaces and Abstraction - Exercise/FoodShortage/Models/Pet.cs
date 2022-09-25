using System;
using System.Collections.Generic;
using System.Text;
using FoodShortage.Contracts;

namespace FoodShortage.Models
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Birthdate { get; set; }

        public string Name { get; set; }
    }
}
