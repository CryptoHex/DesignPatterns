using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Machines
{
    public class Car : IMachine
    {
        public string Name => "Car";

        public void Identify()
        {
            Console.WriteLine("Car is starting.");
        }

        public void Operate()
        {
            Console.WriteLine("Car is stopping.");
        }
    }
}
