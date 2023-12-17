using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Machinegun : IWeapon, IBurstShoot
    {
        public int MinDamage => 3;

        public int MaxDamage => 8;

        public int BurstValue => 3;

        public void BurtsShoot()
        {
            for (int i = 0; i < BurstValue; i++)
            {
                Shoot();
            }
        }

        public void Shoot()
        {
            Console.WriteLine($"piu! Dealed {new Random().Next(MinDamage, MaxDamage)} mg");
        }
    }
}
