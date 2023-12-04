using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.items
{
    internal class Axe : Weapon
    {
        public Axe(string Name, int minDamage, int maxDamage, int attackSpeed, int accuracy, int durability) : base(Name, minDamage, maxDamage, attackSpeed, accuracy, durability)
        {

        }
        public Axe() : base("Axe", 3, 9, 5, 70, 600)
        {

        }
        int CritChance = 30;
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
                        unit.Blodloss = true;

                    }
                    if (unit.Blodloss = true)
                    {
                        unit.Health -= 1;
                        Console.WriteLine($"Был нанесен критический удар, у {unit.Name} началась кровотечение");
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