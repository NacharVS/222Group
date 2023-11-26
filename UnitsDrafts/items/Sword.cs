using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitsDrafts.items
{
    internal class Sword : Weapon
    {
        public Sword(string Wname, int Speedat, int Mindamage, int Maxdamage, int Durabulity, int Accuracy) : base(Wname, Speedat, Mindamage, Maxdamage, Durabulity, Accuracy)
        {

        }

        public Sword () : base("Name", 3, 2, 7, 100, 30)
        {

        }

        public void Crit()
        {
            MinDamage = MinDamage + (MinDamage / 2);
        }
 
    }
}
