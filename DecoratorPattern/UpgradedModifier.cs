using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class UpgradedModifier : WeaponModifier
    {
        public UpgradedModifier(Weapon weapon) : base(weapon)
        {
        }

        protected override int DamageModifier => 4;

        protected override int DurabilityModifier => 4;

        protected override string DescriptionModifier => "Upgraded";
    }
}
