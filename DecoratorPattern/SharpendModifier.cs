using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class SharpendModifier : WeaponModifier
    {
        public SharpendModifier(Weapon weapon) : base(weapon)
        {
            this.weapon = weapon;
        }

        protected override int DamageModifier => 2;
        protected override int DurabilityModifier => -1;
        protected override string DescriptionModifier => "Sharpend";
    }
}
