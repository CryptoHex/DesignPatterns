using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Meat.CookingStrategies
{
    class MediumRareStrategy : ICookingStrategy
    {
        public string Cook()
        {
            return "medium rare";
        }
    }
}
