using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class FishCook : Cook, INextCook
    {
        public FishCook(string name) : base(name)
        {
            this.mealType = "Fish";
        }
    }
}
