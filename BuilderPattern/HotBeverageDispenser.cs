using BuilderPattern.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class HotBeverageDispenser
    {
        //director class
        public HotBeverage PrepareBeverage(HotBeverageBuilder hotBeverageBuilder)
        {
            HotBeverage hotBeverage = hotBeverageBuilder
                                        .SetBeverageType()
                                        .Boil()
                                        .AddIngridients()
                                        .SetCupSize()
                                        .GetHotBeverage();

            return hotBeverage;
        }
    }
}
