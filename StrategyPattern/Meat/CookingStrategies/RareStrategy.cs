using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Meat.CookingStrategies
{
    class RareStrategy : ICookingStrategy
    {
        public string Cook()
        {
            return "rare";
        }
    }
}
