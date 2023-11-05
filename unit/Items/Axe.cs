using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit.Items
{
    internal class Axe : Weapon
    {
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
                    double Damage = new Random().Next(MinDamage, MaxDamage);
                    Damage += Level * 5;
                    x = new Random().Next(1, 101);
                    if (x <= CritChance)
                    {
                        Damage += 1;
                        Console.WriteLine("Был нанесен критический удар, у противника началась кровотечение");
                    }
                    return Damage * DurabilityQuality();
                }
                else
                {
                    Console.WriteLine("Не попал");
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
