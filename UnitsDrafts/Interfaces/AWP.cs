using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.Interfaces
{
    internal class AWP : IWeapon
    {
        public int MinDamage => 10;
        public int MaxDamage => 20;

        public int Accuracy => 70;
        public void Shoot()
        {
            if (Accuracy > new Random().Next(1, 100))
            {
                Console.WriteLine($"Нанесён урон {new Random().Next(MinDamage, MaxDamage)} (AWP)");
            }
            else
                Console.WriteLine("Промах (AWP)");
        }
    }
}
