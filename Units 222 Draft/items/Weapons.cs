using System.Security.Cryptography.X509Certificates;
using Units_222_Draft.units;
using UnitsDrafts;

namespace Units_222_Draft.items
{
    internal class Weapon
    {
        public int MinDamage;
        public int MaxDamage;
        public int AttackSpeed;
        public int Accuracy;
        public int Durability = 100;
        public bool Alive = true;
        public string Name;
        public float Level = 0;

        public Weapon(int minDamage, int maxDamage, int attackSpeed, int accuracy)
        {
            MinDamage = minDamage;//min|max damage на один меньше|больше чтобы был достигнут правильный интервал занчений
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
            Accuracy = accuracy;
        }
        public float Durability_check()
        {
            if (Durability >= 70)
            {
                return 1;
            }
            else if (Durability >= 40)
            {
                return 0.7f;
            }
            else if (Durability > 0)
            {
                return 0.4f;
            }
            else
            {
                Alive = false;
                Console.WriteLine("Оружие сломалось");
                return 0;

            }
        }
        public virtual float Hit(Unit unit)
        {
            Durability--;
            if (Durability > 0)
            {
                float CritChance = 20;
                float CritDamage = 1;
                int x = new Random().Next(1, 100);
                if (x <= Accuracy)
                {
                    float Damage = new Random().Next(MinDamage, MaxDamage);
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
                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }
        
        public void LevelUp()
        {
            if (Level < 10)
            {
                Level += 1;
            }
            else
            {
                Console.WriteLine($"У {Name} Максимальный левел");
            }
        }
    }
}
