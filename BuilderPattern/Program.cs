using BuilderPattern.Builders;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
             HotBeverageDispenser dispenser = new HotBeverageDispenser();

            CoffeeBuilder coffeeBuilder = new CoffeeBuilder();
            HotBeverage coffee = dispenser.PrepareBeverage(coffeeBuilder);
            Console.WriteLine(coffee);

            TeaBuilder teaBuilder = new TeaBuilder();
            HotBeverage tea = dispenser.PrepareBeverage(teaBuilder);
            Console.WriteLine(tea);

            MulledWineBuilder mulledWineBuilder = new MulledWineBuilder();
            HotBeverage mulledWine = dispenser.PrepareBeverage(mulledWineBuilder);
            Console.WriteLine(mulledWine);
        }
    }
}
