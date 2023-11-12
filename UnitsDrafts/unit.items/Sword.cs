using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using unit.items;
using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts.unit.items
{
    internal class Sword : Weapon
    {
        private Weapon _weapon;
        double CritDamage = 1.5;
        double CritChance = 20;
        public Sword() : base(2, 7, 8, 100, 12) 
        {             
        }
        public override double Hit(Unit unit)
        {      
            if (Durability >= 0) 
            {
                Durability -= 2;
                Console.WriteLine(Durability);
                double damage = new Random().Next(MinDamage, MaxDamage);
                var y = new Random().Next(1, 100);
                if (Accuracy >= y)
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
