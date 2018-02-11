using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.PizzaIngridients
{
    public class IngridientList : IEnumerable<Ingridient>
    {
        private List<Ingridient> ingridients;

        public IngridientList()
        {
            this.ingridients = new List<Ingridient>();
        }

        public IngridientList(List<Ingridient> ingridients) : this()
        {
            this.Ingridients.AddRange(ingridients);
        }


        public void Add(Ingridient ingridient)
        {
            this.Ingridients.Add(ingridient);
        }

        public IEnumerator<Ingridient> GetEnumerator()
        {
            return this.ingridients.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.ingridients.GetEnumerator();
        }

        public List<Ingridient> Ingridients { get => ingridients; }

    }
}
