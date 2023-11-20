using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts
{
    internal class Weapon
    {
        public Weapon(int minDamage, int maxDamage, int attackSpeed, int accuracy, int durability, int critChanse, int critDamage)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
            Accuracy = accuracy;
            Durability = durability;
            CritChanse = critChanse;
            CritDamage = critDamage;
        }

        public int MinDamage;
        public int MaxDamage;
        public int AttackSpeed;
        public int Accuracy;
        public int Durability;
        public int CritChanse { get; set; }
        public int CritChance { get; private set; }
        public int Damage { get; private set; }

        public int CritDamage;
        public bool Alive = true;

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

            x = new Random().Next(1, 101);
            if (x <= CritChance)
            {
                Damage = MaxDamage;
                Console.WriteLine("Был нанесен критический удар");

            }
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
    }
}

