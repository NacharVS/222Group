using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            Acuracy = accuracy;
            Drability = durability;
            Bleeding = Bleed;
            StChance = stunchance;
        }

        public string Name { get; set; }
        public int MinDam { get; set; }
        public int MaxDam { get; set; }
        public int AtSpeed { get; set; }
        public int Acuracy { get; set; }
        public int Drability { get; set; }
        public bool Bleeding { get; set; } = false;
        public int StChance { get; set; }
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
            if (Drability > 0)
            {

                if (x <= Acuracy)
                {
                    double damage = new Random().Next(MinDam, MaxDam);
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

        public int AttackSpeed(Unit unit)
        {
            if (AtSpeed < 4)
            {
                Console.WriteLine("Замах");
                Thread.Sleep(1000);
                var x = new Random().Next(1, 101);
                var z = new Random().Next(1, 101);
            }

            else
            if (AtSpeed < 100000 && AtSpeed >= 5)
            {
                Console.WriteLine("Вы замохнулись оружием");
                Thread.Sleep(1500);
                var x = new Random().Next(1, 101);
                var z = new Random().Next(1, 101);
            }
         return 0;
        }
    }
}