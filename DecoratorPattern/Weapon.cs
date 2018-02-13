using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Weapon
    {
        protected int damage;
        protected int durability;
        protected string description;

        public int Damage { get => this.damage; }
        public int Durability { get => this.durability; }
        public string Description { get => this.description; }

        public override string ToString()
        {
            return $"{this.Description} deals {this.Damage} damage and has a durability of {this.Durability}.";
        }
    }
}
