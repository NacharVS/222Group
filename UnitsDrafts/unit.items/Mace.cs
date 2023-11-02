using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit.items;

namespace UnitsDrafts.unit.items
{
    internal class Mace : Weapon
    {
        public int StunChance = 100;
        public Mace() : base(2, 10, 5, 85) 
        { 
        }
        public override double Hit()
        {
            double damage = new Random().Next(MinDamage,MaxDamage);
            var x = new Random().Next(1, 100);
            Console.WriteLine($"Вы нанесли {damage} урона");           
            if (x <= StunChance)
            {
                Console.WriteLine("Герой застанен");
                return damage;
            }
            return damage;
        }
    }
}
