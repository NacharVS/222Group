
using Units_222_Draft.Stats;
using Units_222_Draft.units;
namespace Units_222_Draft.items
{
    internal class Axe : Weapon
    {
        public Axe(int minDamage, int maxDamage, int attackSpeed, int accuracy) : base(minDamage, maxDamage, attackSpeed, accuracy)
        {
        }
        public Axe() : base(2, 10, 1, 70)
        {
            Name = "axe";
        }
        public override float Hit(Unit unit)
        {
            if (Alive)
            {
                Durability--;
                float CritChance = 20;
                float CritDamage = 0.5f;
                var x = new Random().Next(1, 100);
            if (x <= Accuracy)
            {
                float Damage = new Random().Next(MinDamage, MaxDamage);
                    Damage += Level * 5;
                    x = new Random().Next(1, 100);
                if (x <= CritChance)
                {
                    Damage += Damage * CritDamage;
                }
                x = new Random().Next(1, 100);
                if (x <= 30) 
                    {
                        unit.BloodLoss = true;   
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
