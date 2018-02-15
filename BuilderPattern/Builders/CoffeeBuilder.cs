using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Builders
{
    public class CoffeeBuilder : HotBeverageBuilder
    {

        public override HotBeverageBuilder SetBeverageType()
        {
            this.hotBeverage.HotBeverageType = "Coffee";
            return this;
        }

        public override HotBeverageBuilder Boil()
        {
            this.hotBeverage.BoiledLiquid = "Boiled Water";
            return this;
        }

        public override HotBeverageBuilder AddIngridients()
        {
            this.ingridients.Add("Crushed coffee beans");
            this.ingridients.Add("Teaspoon of milk");
            this.ingridients.Add("Two pinches of sugar");
            this.hotBeverage.Ingridients = this.ingridients;
            return this;
        }

        public override HotBeverageBuilder SetCupSize()
        {
            this.hotBeverage.CupSize = "Medium";
            return this;
        }


    }
}
