using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Vehicle_Catalogue
{
    class Car
    {
        public Car(string model, string color, double horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string Model { get; set; }
        
        public string Color { get; set; }

        public double HorsePower { get; set; }
    }
}
