using StrategyPattern.Meat;
using StrategyPattern.Meat.CookingStrategies;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICookingStrategy cookingStrategy = new WellDoneStrategy();
            IMeat steak = new Steak(cookingStrategy);

            Console.WriteLine($"Currently the steak is {steak.State()}");
            Console.WriteLine("Cooking...");
            steak.Cook();
            Console.WriteLine($"The steak is now cooked and it is {steak.State()}");
            Console.WriteLine();
        }
    }
}
