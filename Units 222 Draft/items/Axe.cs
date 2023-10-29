//	-Axe(3 - 9, BLEEDING(-1 HP for 1 turn.chance - 30 %))
//4.UPGRADE(Custom)
using Units_222_Draft.units;
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
        public override double Hit(Unit unit)
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
