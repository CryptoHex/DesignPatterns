using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Meat.CookingStrategies
{
    class MediumStrategy : ICookingStrategy
    {
        public string Cook()
        {
            return "medium";
        }
    }
}
