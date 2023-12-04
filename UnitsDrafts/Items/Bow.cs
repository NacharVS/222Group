using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.Items
{
    internal class Bow: Weapon
    {
        public Bow() : base("Bow", 5, 11, 5, 80, 400, true, 0) { }

        public double CritDamage = 1.5;
        public double CritChance = 20;
        
        public override double Hit(Unit unit)
        {
            if (Drability > 0)
            {
                Drability -= 2;
                double damage = new Random().Next(MinDam, MaxDam);
                var y = new Random().Next(1, 101);
                if (Acuracy >= y)
                {
                    damage += lvl * 5;
                    var x = new Random().Next(1, 101);
                    if (x <= CritChance)
                    {
                        damage *= CritDamage;
                        Console.WriteLine("Крит урон!");
                        return damage;
                    }
                    return damage * Durability_check();
                }
                else
                {
                    Console.WriteLine("Промах!");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Оружие сломалось!");
                return 0;
            }
        }
    }
}
