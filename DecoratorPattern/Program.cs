using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon axe = new Axe();
            Console.WriteLine(axe);
            Console.WriteLine("---");
            axe = new SharpendModifier(axe);
            Console.WriteLine(axe);
            Console.WriteLine("---");
            axe = new ReinforcedModifier(axe);
            Console.WriteLine(axe);
            Console.WriteLine("---");

            Weapon sword = new Sword();
            Console.WriteLine(sword);
            sword = new UpgradedModifier(sword);
            Console.WriteLine(sword);

        }
    }
}
