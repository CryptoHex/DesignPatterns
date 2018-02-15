using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Builders
{
    public class MulledWineBuilder : HotBeverageBuilder
    {

        public override HotBeverageBuilder SetBeverageType()
        {
            this.hotBeverage.HotBeverageType = "Mulled Wine";
            return this;
        }

        public override HotBeverageBuilder Boil()
        {
            this.hotBeverage.BoiledLiquid = "Boiled Red Wine";
            return this;
        }

        public override HotBeverageBuilder AddIngridients()
        {
            this.ingridients.Add("Citrus");
            this.ingridients.Add("Cinnamon");
            this.ingridients.Add("Liqueur");
            this.ingridients.Add("Two spoons of maple Syrup");
            this.hotBeverage.Ingridients = this.ingridients;
            return this;
        }

        public override HotBeverageBuilder SetCupSize()
        {
            this.hotBeverage.CupSize = "Small";
            return this;
        }


    }
}
