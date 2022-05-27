using System;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            double snowballValue = 0;
            double highestValue = int.MinValue;
            int highestSnowballSnow = 0;
            int highestSnowballTime = 0;
            int highestSnowballQuality = 0;

            for (int i = 1; i <= n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = Math.Pow((double)(snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > highestValue)
                {
                    highestValue = snowballValue;
                    highestSnowballSnow = snowballSnow;
                    highestSnowballQuality = snowballQuality;
                    highestSnowballTime = snowballTime;
                }
            }

            Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {highestValue} ({highestSnowballQuality})");
        }
    }
}
