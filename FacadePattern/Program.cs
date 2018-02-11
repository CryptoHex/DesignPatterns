using FacadePattern.PizzaDough;
using FacadePattern.PizzaIngridients;
using FacadePattern.PizzaOven;
using System;
using System.Collections.Generic;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Oven oven = new Oven((OvenType) 0);

            List<Ingridient> ingridients = new List<Ingridient>()
            {
                new Ingridient("Tomatoes"),
                new Ingridient("Ham"),
                new Ingridient("Cheese")
            };
            IngridientList ingridientList = new IngridientList(ingridients);

            Dough dough = new Dough((DoughType) 1);

            Pizza Pizza = new Pizza(oven, dough, ingridientList);
            Console.WriteLine(Pizza);

        }
    }
}
