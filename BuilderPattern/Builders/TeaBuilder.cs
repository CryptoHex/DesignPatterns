using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Builders
{
    public class TeaBuilder : HotBeverageBuilder
    {

        public override HotBeverageBuilder SetBeverageType()
        {
            this.hotBeverage.HotBeverageType = "Tea";
            return this;
        }

        public override HotBeverageBuilder Boil()
        {
            this.hotBeverage.BoiledLiquid = "Boiled Water";
            return this;
        }

        public override HotBeverageBuilder AddIngridients()
        {
            this.ingridients.Add("Black tea bag");
            this.ingridients.Add("Teaspoon of honey");
            this.ingridients.Add("Two pinches of sugar");
            this.hotBeverage.Ingridients = this.ingridients;
            return this;
        }

        public override HotBeverageBuilder SetCupSize()
        {
            this.hotBeverage.CupSize = "Large";
            return this;
        }


    }
}
