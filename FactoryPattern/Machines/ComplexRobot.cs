using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Machines
{
    public class ComplexRobot : IMachine
    {
        public string Name => "Microwave";

        public void Identify()
        {
            Console.WriteLine("Microwave oven is starting.");
        }

        public void Operate()
        {
            Console.WriteLine("Microwave oven is stopping.");
        }
    }
}
