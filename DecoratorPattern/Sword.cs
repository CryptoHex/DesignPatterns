using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Sword : Weapon
    {
        public Sword()
        {
            this.damage = 10;
            this.durability = 9;
            this.description = this.GetType().Name;
        }
    }
}
