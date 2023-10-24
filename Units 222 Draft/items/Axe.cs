﻿//	-Axe(3 - 9, BLEEDING(-1 HP for 1 turn.chance - 30 %))
//3.DURABILITY(Custom) New - 100 %, Worn - 70 %, Old - 40 %.Broken - can't do everything
//4.UPGRADE(Custom)
namespace Units_222_Draft.items
{
    internal class Axe : Weapon
    {
        public Axe(int minDamage, int maxDamage, int attackSpeed, int accuracy) : base(minDamage, maxDamage, attackSpeed, accuracy)
        {
        }
        public Axe() : base(3, 9, 1, 70)
        {
        }
        public override double Hit()
        {
            if (Alive)
            {
                Durability--;
                double CritChance = 20;
                double CritDamage = 0.5;
                var x = new Random().Next(1, 100);
            if (x <= Accuracy)
            {
                double Damage = new Random().Next(MinDamage, MaxDamage);
                x = new Random().Next(1, 100);
                if (x <= CritChance)
                {
                    Damage += Damage * CritDamage;
                }
                return Damage * Durability_check();
            }
            else
            {
                return 0;
            }
            }
            else
            {
                return 0;
            }
            
        }
    }
}
