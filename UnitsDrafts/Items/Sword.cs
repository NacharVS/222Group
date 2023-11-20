using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Sword : Weapon
    {
        public int Chance { get; set; }
        
        public Sword() : base(2, 6, 8, 80,100,30,40)
        {

        }

        public virtual float Crit()
        {
            var x = new Random().Next(1, 101);
            if (x <= Chance)
            {
                return new Random().Next(MinDamage, MaxDamage);
            }
            else
            {
                return 0;
            }
        }

    }
}
