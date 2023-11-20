using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class forge
    {
        public Sword CreateSword()
        {
            Sword sword = new Sword();
            return sword;
        }
        public Bow CreateBow()
        {
            Bow bow = new Bow();
            return bow;
        }
    }
}
