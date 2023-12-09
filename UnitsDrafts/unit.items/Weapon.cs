using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsDrafts;

namespace unit.items
{
    internal class Weapon
    {
        public Weapon(int minDamage, int maxDamage, int attackSpeed, int accuracy, int durability)
        {           
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
            Accuracy = accuracy;
            Durability = durability;
        }
        public int MinDamage { get; set; }

        public int MaxDamage { get; set; }

        public int AttackSpeed { get; set; }

        public int Accuracy { get; set; }

        public int Durability { get; set; }

        public bool Alive = true;

        public int level = 0;

        public double DurabilityCheck()
        {
            if (Durability >= 7)
            {
                return 1;
            }
            else if (Durability >= 4)
            {
                return 0.7;
            }
            else if (Durability > 0)
            {
                return 0.4;
            }
            else
            {
                Alive = false;
                Console.WriteLine("Оружие сломалось");
                return 0;
            }
        }

        public virtual double Hit(Unit unit)
        {
            var x = new Random().Next(1, 100);
            if (Durability > 0)
            {               
                if (x <= Accuracy)
                {
                    double damage = new Random().Next(MinDamage, MaxDamage);
                    return damage * DurabilityCheck();
                }
                else 
                {
                    return 0;
                }
            }
            Console.WriteLine("Оружие сломалось");
            return 0;           
        }

        public void LevelUp()
        {
            if (level < 5)
            {
                level++;
                MinDamage += 2;
                MaxDamage += 3;
                Durability += 5;
                Accuracy += 10;
            }
            else
            {
                Console.WriteLine("у вас макс уровень");
            }
        }
    }
}
