﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit.Items
{
    internal class Sword : Weapon
    {
        public Sword(string Name, int minDamage, int maxDamage, int attackSpeed, int accuracy, int durability) : base(Name, minDamage, maxDamage, attackSpeed, accuracy,durability)
        {

        }
        public Sword() : base("Sword", 2, 7, 8, 80, 450)
        {

        }
        double CritChance = 20;
        public override double Hit(Unit unit)
        {

            if (Durability > 0)
            {
                Durability = Durability - 2;


                int x = new Random().Next(1, 101);
                if (x <= Accuracy)
                {
                    double Damage = new Random().Next(MinDamage, MaxDamage+1);
                    Damage += Level * 5;
                    x = new Random().Next(1, 100);
                    if (x <= CritChance)
                    {
                        Damage = MaxDamage;
                        Damage += Damage * 0.5;
                        Console.WriteLine($"{unit.Name} нанес крит урон в размере {Damage}");
                    }
                    
                    return Damage * DurabilityQuality();
                    
                }
                else
                {
                    Console.WriteLine($"{unit.Name} Не попал");
                    return 0;
                }


            }
            else
            {
                Console.WriteLine("Вы не можете стрелять, оружие сломано");
                return 0;
            }
        }
    }
}
