using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class MeatCook : Cook, INextCook
    {
        public MeatCook(string name) : base(name)
        {
            this.mealType = "Meat";
        }
    }
}
