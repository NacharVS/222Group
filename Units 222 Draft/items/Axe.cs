using Units_222_Draft.Stats;
using Units_222_Draft.units;
using UnitsDrafts;

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
                var chance = new Random().Next(1, 100);
            if (chance <= Accuracy)
            {
                float Damage = new Random().Next(MinDamage, MaxDamage);
                Damage += Level * 5;
                chance = new Random().Next(1, 100);
                //Нанесение урона
                if (chance <= CritChance)
                {
                    Damage += Damage * CritDamage;
                }
                chance = new Random().Next(1, 100);
                //Нанесение кровотечения
                if (chance <= 30) 
                {
                    unit.BloodLoss = true;
                    unit.BloodLossCount += Fight.fight_count + 5;
                    Console.WriteLine();
                    Console.WriteLine($"Нанес кровотечение персовнажу {unit.Name}");
                    Console.WriteLine();
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
