using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public interface INextCook
    {
        void CookMeal(string mealType);
        void SetNextCook(INextCook nextCook); 
    }
}
