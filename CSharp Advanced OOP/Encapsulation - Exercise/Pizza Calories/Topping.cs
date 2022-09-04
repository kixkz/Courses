using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private int weight;
        private string toppingType;
        private readonly Dictionary<string, double> modifiers
            = new Dictionary<string, double>()
            {
                { "meat", 1.2 },
                { "veggies", 0.8 },
                { "cheese", 1.1 },
                { "sauce", 0.9 },
            };

        public Topping(int weight, string toppingType)
        {
            this.Weight = weight;
            this.ToppingType = toppingType;
        }

        public string ToppingType
        {
            get
            {
                return toppingType;
            }
            private set
            {
                if (!modifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                toppingType = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{ToppingType} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }

        public double Calories
                => 2
               * Weight
               * modifiers[ToppingType.ToLower()];
    }
}
