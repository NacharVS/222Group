using System;
using Units_222_Draft.items;
using Units_222_Draft.Stats;

namespace Units_222_Draft.units
{
    internal class Footman : Unit
    {
        public Footman(string name, int maxHealth, int defense, int damage, int speed)
            : base(name, maxHealth, defense, speed)
        {
        }
        public Footman() : base("Footman", 60, 0, 5)
        {
            Weapon = new Sword();
            ClassName = "Footman";
        }
    }
}
