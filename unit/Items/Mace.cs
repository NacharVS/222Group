using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit.units;

namespace unit.Items
{
    internal class Mace: Weapon 
    {

        public Mace(string Name, int minDamage, int maxDamage, int attackSpeed, int accuracy, int durability) : base(Name, minDamage, maxDamage, attackSpeed, accuracy, durability)
        {

        }
        public Mace() : base("Mace", 2, 10, 3, 85, 700)
        {

        }
        int CritChance = 10;
        public override double Hit(Unit unit)
        {

            if (Durability > 0)
            {
                Durability = Durability - 3;


                int x = new Random().Next(1, 101);
                if (x <= Accuracy)
                {
                    double Damage = new Random().Next(MinDamage, MaxDamage+1);
                    Damage += Level * 5;
                    x = new Random().Next(1, 101);
                    if (x <= CritChance)
                    {
                        Stat.Stun(unit);
                        Console.WriteLine($"{unit.Name} оглушил противника");
                        Thread.Sleep(1000);
                        
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
