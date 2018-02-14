using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class DesertCook : Cook, INextCook
    {
        public DesertCook(string name) : base(name)
        {
            this.mealType = "Desert";
        }
    }
}
