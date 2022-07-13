using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    internal class Coffee : HotBeverage
    {
        public Coffee(string name, string caffeine)
            : base(name, 3.50m, 50)
        {
            this.Caffeine = caffeine;
        }
        
        public string Caffeine { get; set; }
    }
}
