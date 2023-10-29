//	-Mace(2 - 10, STUN(Enemy can not make a turn), chance 10 %)

//4.UPGRADE(Custom)
using Units_222_Draft.units;
using UnitsDrafts;

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
            int count_buffer = Fight.fight_count + 2;
            unit.Stunned = true;
            
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
                    chance = new Random().Next(1, 100);
                    if (chance <= 10)
                    {
                        Stun(unit);
                    }
                    double Damage = new Random().Next(MinDamage, MaxDamage);
                    chance = new Random().Next(1, 100);
                    if (chance <= CritChance)
                    {
                        Damage += Damage * CritDamage;
                    }
                    return Damage * Durability_check();
                }
                else
                {
                    Console.WriteLine("Не попал");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Оружие сломалось");
                return 0;
            }   
        }
    }
}
