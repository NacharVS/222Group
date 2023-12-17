using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class shotgun: IWeapon, IBurstShoot
    {
        public int BurtsValue => 2;
        public int MinDamage => 5;

        public int MaxDamage => 12;
        public void Shoot()
        {
            Console.WriteLine($"piu! Dealed {new Random().Next(MinDamage, MaxDamage)} shg");
        }
        public void BurtsShoot()
        {
            for ( int i = 0; i < BurtsValue; i++)
            {
                Shoot();
            }
        }
    }
}
