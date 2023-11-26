using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.items
{
    internal class Bow : Weapon
    {
        public Bow(string Wname, int Speedat, int Mindamage, int Maxdamage, int Durabulity, int Accuracy) : base(Wname, Speedat, Mindamage, Maxdamage, Durabulity, Accuracy)
        {

        }

        public Bow() : base("Name", 3, 1, 15, 100, 30)
        {

        }
 

    }
}
