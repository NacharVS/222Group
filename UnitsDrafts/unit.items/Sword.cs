using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using unit.items;

namespace UnitsDrafts.unit.items
{
    
    internal class Sword : Weapon
    {
        private Weapon _weapon;
        double CritDamage = 1.5;
        double CritChance = 20;
        public Sword() : base(2, 7, 8, 100) 
        {             
        }
        public override double Hit(Unit unit)
        {      
            if (Durability >= 0) 
            {
                Durability = Durability - 2;
                double damage = new Random().Next(MinDamage, MaxDamage);
                var y = new Random().Next(1, 100);
                if (Accuracy >= y)
                {
                    var x = new Random().Next(1, 100);
                    if (x <= CritChance)
                    {
                        damage *= CritDamage;
                        Console.WriteLine("Выпал Крит!!!");
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
                Console.WriteLine("Оружие сломалось");
                return 0;
            }        
        }
    }
}
