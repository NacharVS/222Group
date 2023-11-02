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
        public Weapon(int minDamage, int maxDamage, int attackSpeed, int accuracy )
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
            Accuracy = accuracy;
        }
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
                Console.WriteLine("Оружие сломалось");
                return 0;
            }
        }
        public int MinDamage { get; set; }

        public int MaxDamage { get; set; }

        public int AttackSpeed { get; set; }

        public int Accuracy { get; set; }

        public int Durability = 100;


        public virtual double Hit()
        {
            var x = new Random().Next(1, 100);
            if (x <= Accuracy)
            {
                return new Random().Next(MinDamage, MaxDamage);
            }
            else 
            {
                return 0;
            }
        }
    }
}
