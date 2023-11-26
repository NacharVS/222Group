using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.Items
{
    internal class Bow : Weapon
    {
        public Bow(string name, int minDamage, int maxDamage, int attackspeed, int accuracy, int durability) : base(name, minDamage, maxDamage, attackspeed, accuracy, durability)
        {
        }
        public Bow() : base("Bow", 4, 8, 10, 50, 1000)
        {
        }
        public override int Hit(Unit unit)
        {
            {
                if (WeaponAlive)
                {
                    Durability -= 50;
                    var x = new Random().Next(1, 100);
                    if (x <= Accuracy)
                    {
                        int Damage = new Random().Next(MinDamage, MaxDamage);
                        x = new Random().Next(1, 100);
                        if (x <= 35)
                        {
                            unit.Bleeding = true;
                            for (int i = 0; i < 5; i++)
                            {
                                unit.Health -= 2;
                            }
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
