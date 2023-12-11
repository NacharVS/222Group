using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.Interfaces
{
    public class Rifle : IWeapon
    {
        public int MinDamage => 3;
        public int MaxDamage => 8;

        public int Durability { get; set; }
        public void Shoot()
        {
            Console.WriteLine($"Нанесён урон {new Random().Next(MinDamage, MaxDamage)}");
        }
    }
}
