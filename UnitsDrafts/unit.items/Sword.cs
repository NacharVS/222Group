using System;
using System.Collections.Generic;
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
        public Sword() : base(2, 7, 8, 80) 
        {             
        }
        public override double Hit()
        {
            double damage = new Random().Next(MinDamage, MaxDamage);
            var x = new Random().Next(1, 100);
            Console.WriteLine($"Вы нанесли {damage} урона");
            if (x <= CritChance)
            {                
                damage = damage * CritDamage;
                Console.WriteLine("Выпал Крит!!!");
                Console.WriteLine($"Вы нанесли {damage} урона");
                return damage;                
            }
            return damage;
        }
    }
}
