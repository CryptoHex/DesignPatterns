using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.PizzaOven
{
    public class Oven
    {
        private OvenType ovenType;

        public Oven(OvenType oventype)
        {
            this.ovenType = oventype;
        }

        public override string ToString()
        {
            return ovenType.ToString();
        }
    }
}
