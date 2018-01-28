using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Machines
{
    public class UnknownMachine : IMachine
    {
        public string Name
        {
            get { return string.Empty; }
        }

        public void Identify()
        {
            Console.WriteLine("Machine not recognised");
        }

        public void Operate()
        {

        }
    }
}
