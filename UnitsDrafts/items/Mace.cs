using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.items
{
    internal class Mace : Weapon
    {
        public Mace(string Wname, int Speedat, int Mindamage, int Maxdamage, int Durabulity, int Accuracy) : base(Wname, Speedat, Mindamage, Maxdamage, Durabulity, Accuracy)
        {

        }

        public Mace() : base("Name", 3, 2, 10, 100, 30)
        {

        }

    }
}
