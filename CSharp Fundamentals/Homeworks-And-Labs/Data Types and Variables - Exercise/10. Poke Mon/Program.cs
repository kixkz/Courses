using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            double originalPower = pokePower * 0.50;
            int distance = int.Parse(Console.ReadLine());
            byte exhausFactor = byte.Parse(Console.ReadLine());
            int pokeCounter = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokeCounter++;
                if ((pokePower == originalPower) && exhausFactor != 0)
                {
                    pokePower /= exhausFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCounter);
        }
    }
}
