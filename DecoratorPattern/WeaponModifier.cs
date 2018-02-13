using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class WeaponModifier : Weapon
    {
        protected Weapon weapon;
        protected WeaponModifier(Weapon weapon)
        {
            this.weapon = weapon;
            Modify();
        }

        protected abstract int DamageModifier { get; }
        protected abstract int DurabilityModifier { get; }
        protected abstract string DescriptionModifier { get; }

        protected void Modify()
        {
            this.damage = this.weapon.Damage + this.DamageModifier;
            this.durability = this.weapon.Durability + this.DurabilityModifier;
            this.description = this.DescriptionModifier +" "+ this.weapon.Description.ToLower();
        }

    }
}
