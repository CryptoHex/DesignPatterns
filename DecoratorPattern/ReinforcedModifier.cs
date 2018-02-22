using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ReinforcedModifier : WeaponModifier
    {
        public ReinforcedModifier(Weapon weapon) : base(weapon)
        {
        }

        protected override int DamageModifier => 1;
        protected override int DurabilityModifier => 1;
        protected override string DescriptionModifier => "Reinforced";
    }
}
