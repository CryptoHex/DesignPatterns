using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.PizzaIngridients
{
    public class Ingridient
    {
        private string name;

        public Ingridient(string name)
        {
            this.name = name;
        }

        public string Name { get => name; }
    }
}
