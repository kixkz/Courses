using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studetsCnt = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());
            
            double priceForSabers = priceOfLightsaber * Math.Ceiling(studetsCnt * 1.1);
            double priceForRobes = studetsCnt * priceOfRobe;
            double priceForBelts = 0;

            for (int i = 1; i <= studetsCnt; i++)
            {
                if (i % 6 == 0)
                {
                    priceForBelts += priceOfBelt - priceOfBelt;
                }
                else
                {
                    priceForBelts += priceOfBelt;
                }
            }
            
            double totalPrice = priceForSabers + priceForRobes + priceForBelts;

            if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - money:f2}lv more.");
            }
        }
    }
}
