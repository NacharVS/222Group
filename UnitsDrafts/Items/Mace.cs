using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.Items
{
    internal class Mace : Weapon
    {
       
        public Mace() : base("Mace", 2, 10, 30, 60, 100, false, 40)
        {
        }
        public override double Hit(Unit unit)
        {
            if (Drability > 0)
            {
                double damage = new Random().Next(MinDam, MaxDam);
                Drability = Drability - 2;
                int y = new Random().Next(1, 100);
                if (Acuracy >= y)
                {
                    damage += lvl * 5;
                    int x = new Random().Next(1, 100);
                    if (x <= StChance)
                    {
                        Console.WriteLine("Противник оглушен");
                        unit.StChance = true;
                    }
                    return damage * Durability_check();
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
