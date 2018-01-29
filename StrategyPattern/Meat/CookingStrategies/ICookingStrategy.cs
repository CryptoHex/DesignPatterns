using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Meat.CookingStrategies
{
    public interface ICookingStrategy
    {
        string Cook();
    }
}
