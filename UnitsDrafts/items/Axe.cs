using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.items
{
    internal class Bow : Weapon
    {
        public Bow(string Name, int minDamage, int maxDamage, int attackSpeed, int accuracy, int durability) : base(Name, minDamage, maxDamage, attackSpeed, accuracy, durability)
        {

        }
        public Bow() : base("Bow", 1, 15, 5, 55, 200)
        {

        }
        int CritChance = 20;
        int CritDamage = 3;
        public override double Hit(Unit unit)
        {

            if (Durability > 0)
            {
                Durability = Durability - 3;


                int x = new Random().Next(1, 101);
                if (x <= Accuracy)
                {
                    double Damage = new Random().Next(MinDamage, MaxDamage + 1);
                    Damage += Level * 5;
                    x = new Random().Next(1, 101);
                    if (x <= CritChance)
                    {
                        Damage = MaxDamage;
                        Damage = Damage * CritDamage;
                        Console.WriteLine($"{unit.Name} нанес крит урон в размере {Damage} при помощи лука");
                    }
                    return Damage * DurabilityQuality();
                }
                else
                {
                    Console.WriteLine($"{unit.Name} промазал");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Оружие поломано");
                return 0;
            }
        }
    }
}