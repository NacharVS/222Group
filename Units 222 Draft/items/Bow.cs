
//4.UPGRADE(Custom)
using Units_222_Draft.units;
namespace Units_222_Draft.items
{
    internal class Bow : Weapon
    {
        public Bow(int minDamage, int maxDamage, int attackSpeed, int accuracy) : base(minDamage, maxDamage, attackSpeed, accuracy)
        {
        }
        public Bow() : base(0,16,1,55)
        {
            Name = "bow";
        }
        public override double Hit(Unit unit)
        {
            Durability--;
            if (Durability > 0)
            {
                Durability--;
                double CritChance = 100;
                double CritDamage = 3;
                var x = new Random().Next(1, 100);
                if (x <= Accuracy)
                {
                    double Damage = new Random().Next(MinDamage, MaxDamage);
                    Damage += Level * 5;
                    x = new Random().Next(1, 100);
                    if (x <= CritChance)
                    {
                        Damage += Damage * CritDamage;
                    }
                    return Damage * Durability_check();
                }
                else
                {
                    Console.WriteLine("Не Попал");
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
