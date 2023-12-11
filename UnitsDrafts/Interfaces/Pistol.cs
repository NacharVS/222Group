using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.Interfaces
{
    public class Pistol : IWeapon
    {
        public int MinDamage => 2;
        public int MaxDamage => 6;

        public int Durability { get; set; }
        public void Shoot()
        {
            Console.WriteLine($"Нанесён урон {new Random().Next(MinDamage, MaxDamage)}");
        }
    }
}
