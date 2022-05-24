using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCnt = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0;

            switch (typeOfTheGroup)
            {
                case "Students":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = peopleCnt * 8.45;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = peopleCnt * 9.80;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = peopleCnt * 10.46;
                    }

                    if (peopleCnt >= 30)
                    {
                        price *= 0.85;
                    }
                    break;
                case "Business":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = peopleCnt * 10.90;
                        if (peopleCnt >= 100)
                        {
                            price = (peopleCnt - 10) * 10.90;
                        }
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = peopleCnt * 15.60;
                        if (peopleCnt >= 100)
                        {
                            price = (peopleCnt - 10) * 15.60;
                        }
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = peopleCnt * 16;
                        if (peopleCnt >= 100)
                        {
                            price = (peopleCnt - 10) * 16;
                        }
                    }
                    break;
                case "Regular":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = peopleCnt * 15;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = peopleCnt * 20;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = peopleCnt * 22.50;
                    }

                    if (peopleCnt >= 10 && peopleCnt <= 20)
                    {
                        price *= 0.95;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
