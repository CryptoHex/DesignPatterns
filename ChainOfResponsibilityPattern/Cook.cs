using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public abstract class Cook : INextCook
    {
        private string name;
        protected string mealType;
        private INextCook nextCook;

        public Cook(string name)
        {
            this.name = name;
        }

        public void CookMeal(string mealType)
        {
            if(this.mealType.ToLower() == mealType.ToLower())
            {
                Console.WriteLine($"Cook {this.name} is cooking the {this.mealType} type meal.");
                Console.WriteLine("---");
            }
            else 
            {

                Console.WriteLine($"Cook {this.name} can't cook a {this.mealType} type meal.");

                if(nextCook != null)
                {
                    Console.WriteLine($"Passing the order to the next cook....");
                    Console.WriteLine("---");
                    this.nextCook.CookMeal(mealType);
                }
                else
                {
                    Console.WriteLine($"There are no cooks who can handle a {mealType} type meal.");
                    Console.WriteLine("---");
                }
            }  
        }

        public virtual void SetNextCook(INextCook nextCook)
        {
            this.nextCook = nextCook;
        }


    }
}
