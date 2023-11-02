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
        public int BleedChance = 30;
        public int BleedDamage = 1;
        public Axe() : base(3, 9, 6, 70) 
        { 
        }
        public override double Hit()
        {
            double damage = new Random().Next(MinDamage, MaxDamage);
            var x = new Random().Next(1, 100);
            if (x <= BleedChance)
            {
                damage += BleedDamage;
                Console.WriteLine("У вас кровотечение!!!, + 1 урон");               
                Console.WriteLine($"Вы нанесли {damage} урона");
                return damage;
            }
            return damage;
        }
    }
}
