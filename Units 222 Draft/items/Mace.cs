using Units_222_Draft.units;
using Units_222_Draft.Stats;
using UnitsDrafts;

namespace Units_222_Draft.items
{
    internal class Mace : Weapon
    {
        public Mace(int minDamage, int maxDamage, int attackSpeed, int accuracy) : base(minDamage, maxDamage, attackSpeed, accuracy)
        {
        }
        public Mace() : base(1, 11, 1, 85)
        {
            Name = "mace";
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
                        Stat.Stun(unit);
                    }
                    double Damage = new Random().Next(MinDamage, MaxDamage);
                    Damage += Level * 5;
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
