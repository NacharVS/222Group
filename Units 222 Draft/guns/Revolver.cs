using Units_222_Draft.Stats;
using Units_222_Draft.units;

namespace Units_222_Draft.guns
{
    internal class Revolver : Gun, IGun, IGunsDurability
    {
        public Revolver(int maxDamage, int minDamage, float durability, string name, bool alive, int accuracy, int level)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Durability = durability;
            Name = name;
            Alive = alive;
            Accuracy = accuracy;
            Level = level;
        }

        public int MaxDamage { get ; set ; }
        public int MinDamage { get ; set ; }
        public float Durability { get ; set ; }
        public string Name { get; set ; }
        public bool Alive { get; set; }
        public int Accuracy { get; set; }
        public int Level { get; set; }

        public float Durability_check()
        {
            if (Durability >= 70)
            {
                return 1f;
            }
            else if (Durability >= 40)
            {
                return 0.7f;
            }
            else if (Durability >=10)
            {
                return 0.4f;
            }
            else if(Durability >=1)
            {
                return 0.1f;
            }
            else
            {
                return 0f;
            }
        }

        public float Shoot()
        {
            if (Alive)
            {
                float CritChance = 20;
                float CritDamage = 0.5f;
                var chance = new Random().Next(1, 100);
                if (chance <= Accuracy)
                {
                    chance = new Random().Next(1, 100);
                    
                    float Damage = new Random().Next(MinDamage, MaxDamage);
                    chance = new Random().Next(1, 100);
                    if (chance <= CritChance)
                    {
                        Damage += Damage * CritDamage;
                    }
                    Durability--;
                    return Damage * Durability_check();
                }
                else
                {
                    Console.WriteLine("Не попал");
                    Durability--;
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
