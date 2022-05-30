using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            List<Item> items = new List<Item>();
            double priceForBox = 0;
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int serialNumber = int.Parse(tokens[0]);
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                double itemPrice = double.Parse(tokens[3]);

                Item item = new Item();
                item.Name = itemName;
                item.Price = itemPrice;
                items.Add(item);

                priceForBox = item.Price * itemQuantity;

                Box box = new Box(serialNumber, item, itemQuantity, priceForBox);
                boxes.Add(box);

                input = Console.ReadLine();
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(boxes => boxes.PriceForBox).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- {box.PriceForBox:f2}");
            }
        }
    }
}
