using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using unit.items;

namespace UnitsDrafts.unit.items
{
    internal class Mace : Weapon
    {
        public int StunChance = 10;
        public Mace() : base(2, 10, 5, 85, 10) 
        { 
        }
        public override double Hit(Unit unit)
        {
            if (Durability > 0) 
            {
                double damage = new Random().Next(MinDamage, MaxDamage);
                Durability = Durability - 2;
                int y = new Random().Next(1, 100);
                if (Accuracy >= y) 
                {
                    damage += level * 5;
                    int x = new Random().Next(1, 100);
                    if (x <= StunChance)
                    {
                        Console.WriteLine("Противник оглушен");
                        unit.Stun = true;
                    }                   
                    return damage * DurabilityCheck();
                }
                else
                {
                    Console.WriteLine("Промах");
                    return 0;
                }  
            }
            Console.WriteLine("Оружие сломалось!");
            return 0;
        }
    }
}
