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
        public Weapon(int minDamage, int maxDamage, int attackSpeed, int accuracy)
        {           
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
            Accuracy = accuracy;
        }
        public int MinDamage { get; set; }

        public int MaxDamage { get; set; }

        public int AttackSpeed { get; set; }

        public int Accuracy { get; set; }

        public int Durability = 100;

        public bool Alive = true;

        public double Durability_check()
        {
            if (Durability >= 70)
            {
                return 1;
            }
            else if (Durability >= 40)
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
                    return damage * Durability_check();
                }
                else 
                {
                    return 0;
                }
            }
            Console.WriteLine("Оружие сломалось");
            return 0;           
        }
    }
}
