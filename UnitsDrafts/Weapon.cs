﻿using System;
using System.Threading.Tasks;
using static UnitsDrafts.Weapon;

namespace UnitsDrafts
{
    internal class Weapon
    {
        public Weapon(string name, int minDamage, int maxDamage, int attackSpeed, int accuracy, int durability, bool Bleed)
        {
            WepName = name; MinDamage = minDamage;
            MaxDamage = maxDamage; AttackSpeed = attackSpeed;
            Accuracy = accuracy; Durability = durability;
            Bleede = Bleed;
        }
        public delegate void DamageDeligate(Unit unit, Weapon weapon);
        DamageDeligate damage;
        public string WepName { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int AttackSpeed { get; set; }
        public int Accuracy { get; set; }
        public int Durability { get; set; }
        public bool Bleede { get; set; } = false;

        public virtual int Hit(Unit unit)
        {
            var x = new Random().Next(1, 101);
            if (Bleede = true && x <= Accuracy && Durability != 0)
            {
                return new Random().Next(MinDamage, MaxDamage + 1);
                Thread.Sleep(10000);
                for (int i = 5; i >= 0; i--)
                {
                    return unit.Health = unit.Health - new Random().Next(1, 5);

                }

            }
            if (x <= Accuracy && Durability != 0)
            {
                Durability = Durability - 50;
                return unit.Health = unit.Health - new Random().Next(MinDamage, MaxDamage + 1);
            }
            else
            {
                return 0;
            }
        }
        public virtual int attackSS(Unit unit)
        {
            if (AttackSpeed < 5)
            {
                Console.WriteLine("Вы замохнулись оружием");
                Thread.Sleep(10000);
                Console.WriteLine("Вы попали");
                return Hit(unit);
            }
            if (AttackSpeed < 15)
            {
                Console.WriteLine("Вы замохнулись оружием");
                Thread.Sleep(5000);
                Console.WriteLine("Вы попали");
                return Hit(unit);
            }
            else
                return Hit(unit);
        }

    }
}
