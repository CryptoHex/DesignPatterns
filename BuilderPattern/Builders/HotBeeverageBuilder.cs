using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Builders
{
    public abstract class HotBeverageBuilder
    {
        protected HotBeverage hotBeverage;
        protected List<string> ingridients;
        protected string hotBeverageType;

        protected HotBeverageBuilder()
        {
            this.hotBeverage = new HotBeverage();
            this.ingridients = new List<string>();
        }

        public abstract HotBeverageBuilder SetBeverageType();
        public abstract HotBeverageBuilder Boil();
        public abstract HotBeverageBuilder AddIngridients();
        public abstract HotBeverageBuilder SetCupSize();

        public HotBeverage GetHotBeverage()
        {
            return hotBeverage;
        }
    }
}
