using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Sword : Weapon
    {
        private Weapon _weapon;
        public double CritDamage = 1.5;
        public double CritChance = 20;

        public Sword() : base("Sword", 2, 7, 20, 60, 100, false, 0)
        {

        }





        public override double Hit(Unit unit)
        {
            if (Durability > 0)
            {
                Durability -= 2;
                double damage = new Random().Next(MinDamage, MaxDamage);
                var y = new Random().Next(1, 101);
                if (Accuracy >= y)
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


        public virtual float Crit()
        {
            var x = new Random().Next(1, 101);
            if (x <= CritChance)
            {
                return new Random().Next(MinDamage, MaxDamage);
            }
            else
            {
                return 0;
            }
        }

    }
}