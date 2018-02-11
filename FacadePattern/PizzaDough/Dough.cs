using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.PizzaDough
{
    public class Dough
    {
        private DoughType doughType;

        public Dough(DoughType doughType)
        {
            this.doughType = doughType;
        }

        public override string ToString()
        {
            return doughType.ToString();
        }
    }
}
