using StrategyPattern.Meat;
using StrategyPattern.Meat.CookingStrategies;

namespace StrategyPattern.Meat
{
    public class Steak : IMeat
    {
        private ICookingStrategy cookingStrategy;
        private string state = "raw";

        public Steak(ICookingStrategy cookingStrategy)
        {
            this.CookingStrategy = cookingStrategy;
        }

        public void Cook()
        {
            this.state = this.CookingStrategy.Cook();
        }

        public string State()
        {
            return state;
        }



        public ICookingStrategy CookingStrategy { get => cookingStrategy; set => cookingStrategy = value; }
    }
}
