using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CrossMotorcycle sport = new CrossMotorcycle(100, 100);

            sport.Drive(9);
            Console.WriteLine(sport.Fuel);
        }
    }
}
