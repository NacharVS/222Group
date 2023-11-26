using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.items
{
    internal class Axe : Weapon
    {
        public Axe(string Wname, int Speedat, int Mindamage, int Maxdamage, int Durabulity, int Accuracy) : base(Wname, Speedat, Mindamage, Maxdamage, Durabulity, Accuracy)
        {

        }

        public Axe() : base("Name", 3, 3, 9, 100, 30)
        {

        }

    }
}
