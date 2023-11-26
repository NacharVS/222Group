using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.Items
{
    internal class Nothing : Weapon
    {
        public Nothing(string name, int minDamage, int maxDamage, int attackspeed, int accuracy, int durability) : base(name, minDamage, maxDamage, attackspeed, accuracy, durability)
        {
        }
        public Nothing() : base("Nothing", 0, 0, 0, 0, 0)
        {
            WeaponName = "Nothing";
        }
        public override int Hit(Unit unit)
        {
            {
                if (WeaponAlive)
                {
                    Durability -= 0;
                    var x = new Random().Next(1, 100);
                    if (x <= Accuracy)
                    {
                        int Damage = new Random().Next(MinDamage, MaxDamage);
                        x = new Random().Next(1, 100);
                        if (x <= 20)
                        {
                            unit.Stunned = true;
                        }
                        return Damage;
                    }
                    else
                    {
                        Console.WriteLine("Не попал");
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
}