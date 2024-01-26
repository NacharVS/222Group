using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
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

        public virtual int Hit()
        {
            var x = new Random().Next(1, 101);
            if (x <= Accuracy)
            {
                return new Random().Next(MinDamage, MaxDamage + 1);
            }
            else
            {
                return 0;
            }
        }
    }
}
