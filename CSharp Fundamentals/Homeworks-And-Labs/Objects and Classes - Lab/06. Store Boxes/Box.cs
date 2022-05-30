using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Store_Boxes
{
    class Box
    {
        public Box(int serialNumber, Item item, int itemQuantity, double priceForBox)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            PriceForBox = priceForBox;
        }

        public int SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public double PriceForBox { get; set; }
    }
}
