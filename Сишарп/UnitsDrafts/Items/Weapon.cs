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
        public Weapon(string name, int minDamage, int maxDamage, int attackSpeed, int accuracy, int durability, bool Bleed, int stunchance)
        {
            Name = name;
            MinDam = minDamage;
            MaxDam = maxDamage;
            AtSpeed = attackSpeed;
            Accuracy = accuracy;
            Drability = durability;
            Bleeding = Bleed;
            Stunchance = stunchance;
        }

        public string Name { get; set; }
        public int MinDam { get; set; }
        public int MaxDam { get; set; }
        public int AtSpeed { get; set; }
        public int Acuracy { get; set; }
        public int Drability { get; set; }
        public bool Bleeding { get; set; } = false;
        public int Stunchance { get; set; }
        public bool AliveWep = true;
        public int lvl = 0;


        public float Durability_check()
        {
            if (Drability >= 70)
            {
                return 1;
            }
            else if (Drability >= 40)
            {
                return 0.7f;
            }
            else if (Drability > 0)
            {
                return 0.4f;
            }
            else
            {
                AliveWep = false;
                Console.WriteLine("Оружие сломалось");
                return 0;

            }
        }

        public virtual double Hit(Unit unit)
        {
            var x = new Random().Next(1, 101);
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

        public void LevelUp()
        {
            if (lvl < 5)
            {
                lvl++;
                MinDam += 2;
                MaxDam += 3;
                Drability += 5;
                Acuracy += 10;
            }
            else
            {
                Console.WriteLine("у вас макс уровень");
            }
        }


        public void Bleed()
        {
            for (int i = 0; i < 3; i++)
            {
                int bleedingDamage = MaxDam / 3;
                Console.WriteLine($"Вы получаете  {bleedingDamage} урона от кровотечения.");
            }
        }









    }
}