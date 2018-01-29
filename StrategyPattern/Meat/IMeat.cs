using StrategyPattern.Meat.CookingStrategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Meat
{
    public interface IMeat
    {
        void Cook();

        string State();
    }
}
