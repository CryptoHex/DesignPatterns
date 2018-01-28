using FactoryPattern.Machines;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string description = Console.ReadLine().ToLower();
            IMachine machine = new MachineFactory().CreateInstance(description);
            machine.Identify();
            machine.Operate();

            Console.ReadKey();
        }
    }
}
