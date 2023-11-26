using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.Items
{
    internal class Axe : Weapon
    {

        public Axe() : base("Axe", 3, 9, 50, 70, 500, true, 10)
        {

        }

        public void Bleed()
        {
            for (int i = 0; i < 3; i++)
            {
                int bleedingDamage = MaxDam / 3;
                Console.WriteLine($"Вы получаете  {bleedingDamage} урона от кровотечения.");
            }
        }

    }
}
