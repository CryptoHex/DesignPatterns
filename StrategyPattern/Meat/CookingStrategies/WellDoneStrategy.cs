using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Meat.CookingStrategies
{
    class WellDoneStrategy : ICookingStrategy
    {
        public string Cook()
        {
            return "well done";
        }
    }
}
