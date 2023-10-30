
//4.UPGRADE(Custom)
using Units_222_Draft.units;
namespace Units_222_Draft.items
{
    internal class Sword : Weapon
    {
        public Sword(int minDamage, int maxDamage, int attackSpeed, int accuracy) : base(minDamage, maxDamage, attackSpeed, accuracy)
        {
        }

        public Sword() : base (2,7,5,90)
        {
            Name = "sword";
        }
        double CritChance = 20;
        double CritDamage = 0.5;

        
        public override double Hit(Unit unit)
        {
            Durability--;
            if (Alive)
            {
                Durability--;
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
