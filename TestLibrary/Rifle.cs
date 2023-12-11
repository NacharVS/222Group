using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Rifle : IWeapon
    {
        public int MinDamage => 5;

        public int MaxDamage => 11;

        public void Shoot()
        {
            Console.WriteLine($"Buh! Dealed {new Random().Next(MinDamage, MaxDamage)}");
        }
    }
    
}
