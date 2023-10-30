using System;
using Units_222_Draft.items;

namespace Units_222_Draft.units
{
    internal class Archer : Unit
    {
        public Archer() : base("Archer", 40, 0, 15)
        {
            if (Health < MaxHealth * 0.4)
            {
                Speed += 4;
            }
            Weapon = new Axe();
        }
        
    }
}


