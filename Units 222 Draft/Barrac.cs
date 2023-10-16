using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Barracs
    {
        public Footman SpawnFootman() 
        {
            ++Stat.FootmanQuantity;
            ++Stat.AliveQuantity;
            return new Footman();
        }
        public Archer SpawnArcher()
        {
            ++Stat.ArcherQuantity;
            ++Stat.AliveQuantity;
            return new Archer();
        }
    }
}
