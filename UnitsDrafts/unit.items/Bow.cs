using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit.items;

namespace UnitsDrafts.unit.items
{
    internal class Bow : Weapon
    {
        public int CritChance = 20;
        public int CritDamage = 3;
        public Bow() : base(1, 15, 2, 55, 13) 
        {           
        }
        public override double Hit(Unit unit)
        {
            if (Durability > 0)
            {
                Durability = Durability - 2;
                double damage = new Random().Next(MinDamage, MaxDamage);
                var y = new Random().Next(1, 100);
                if(Accuracy >= y) 
                {
                    damage += level * 5;
                    var x = new Random().Next(1, 100);
                    if (x <= CritChance)
                    {
                         damage *= CritDamage;
                        Console.WriteLine("Выпал Крит!!!");
                        return damage;
                    }
                    return damage * DurabilityCheck();
                }
                else 
                {
                    Console.WriteLine("Промах!");
                }
                return 0;
            }
            Console.WriteLine("Оружие сломалось!");
            return 0;
        }
    }
}
