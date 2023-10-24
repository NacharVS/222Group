//	-Mace(2 - 10, STUN(Enemy can not make a turn), chance 10 %)
//3.DURABILITY(Custom) New - 100 %, Worn - 70 %, Old - 40 %.Broken - can't do everything
//4.UPGRADE(Custom)
using Units_222_Draft.units;

namespace Units_222_Draft.items
{
    internal class Mace : Weapon
    {
        public Mace(int minDamage, int maxDamage, int attackSpeed, int accuracy) : base(minDamage, maxDamage, attackSpeed, accuracy)
        {
        }
        public Mace() : base(2, 10, 1, 85)
        {

        }
        public void Stun(Unit unit)
        {

        }
        public override double Hit(Unit unit)
        {
            if (Alive)
            {
                Durability--;
                double CritChance = 20;
                double CritDamage = 0.5;
                var chance = new Random().Next(1, 100);
            if (chance <= Accuracy)
            {
                double Damage = new Random().Next(MinDamage, MaxDamage);
                    chance = new Random().Next(1, 100);
                if (chance <= CritChance)
                {
                    Damage += Damage * CritDamage;
                }
                return Damage * Durability_check();
                if (Alive)
                {
                    chance = new Random().Next(1, 100);
                    if (chance <= 10)
                    {
                        Stun(unit);
                    }
                }
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
