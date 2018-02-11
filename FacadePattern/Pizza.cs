using FacadePattern.PizzaDough;
using FacadePattern.PizzaIngridients;
using FacadePattern.PizzaOven;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Pizza
    {
        private Oven oven;
        private Dough dough;
        private IngridientList ingridientList;

        public Pizza(Oven oven, Dough dough, IngridientList ingridientList)
        {
            this.oven = oven;
            this.dough = dough;
            this.ingridientList = ingridientList;           
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The pizza dough is {dough}.");
            sb.AppendLine("The Ingridients are: ");
            foreach(var ingridient in ingridientList)
            {
                sb.AppendLine($"-{ingridient.Name}");
            }
            sb.AppendLine($"And the pizza it will be baked in a {oven} oven.");
            sb.AppendLine("Bon Appetit");
            return sb.ToString();
        }

    }
}
