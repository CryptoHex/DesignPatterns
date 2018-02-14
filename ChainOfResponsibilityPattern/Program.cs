using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Cook cookOne = new FishCook("Oliver");
            Cook cookTwo = new MeatCook("Ramsy");
            Cook cookThree = new DesertCook("Duncan");

            cookOne.SetNextCook(cookTwo);
            cookTwo.SetNextCook(cookThree);

            cookOne.CookMeal("Desert");
            cookOne.CookMeal("Soup");
        }
    }
}
