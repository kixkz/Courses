using System;
using FoodShortage.Core;

namespace FoodShortage
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
