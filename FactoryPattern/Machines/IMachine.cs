using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Machines
{
    public interface IMachine
    {
        string Name { get; }
        void Identify();
        void Operate();
    }
}
