using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.Interfaces
{
    public class MachineGun : IWeapon, IBurstShoot
    {
        public int MinDamage => 4;
        public int MaxDamage => 9;

        public int BurstValue => 3;

        public void BurstShoot()
        {
            for (int i = 0; i < BurstValue; i++)
            {
                Shoot();
            }
        }
        public void Shoot()
        {
            Console.WriteLine($"Нанесён урон {new Random().Next(MinDamage, MaxDamage)} (MachineGun)");
        }
    }
}
