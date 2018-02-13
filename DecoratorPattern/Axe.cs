using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Axe : Weapon
    {
        public Axe()
        {
            this.damage = 13;
            this.durability = 7;
            this.description = this.GetType().Name;
        }
    }
}
