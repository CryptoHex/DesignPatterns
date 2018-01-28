using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Machines
{
    public class Robot : IMachine
    {
        public string Name => "Robot";

        public void Identify()
        {
            Console.WriteLine("Robot is starting.");
        }

        public void Operate()
        {
            Console.WriteLine("Robot is stopping.");
        }
    }
}
