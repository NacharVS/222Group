using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit.items;

namespace UnitsDrafts.unit.items
{
    internal class Axe : Weapon
    {
        public int BleedChance = 100;
        public int BleedDamage = 1;
        public Axe() : base(3, 9, 6, 70) 
        { 
        }
        public override double Hit(Unit unit)
        {
            if(Durability > 0)
            {
                Durability = Durability - 2;
                double damage = new Random().Next(MinDamage, MaxDamage);
                var x = new Random().Next(1, 100);
                if (Accuracy >= x)
                {            
                    if (x <= BleedChance)
                    {
                        unit.BloodLoss = true;
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
