using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Barracs
    {
        public Footman CreateFootman()
        {
            ++Stat.FootmanQuant;
            ++Stat.FootmanQuant;
            return new Footman();
        }

        public Archer CreateArcher()
        {
            ++Stat.ArcherQuant;
            return new Archer();
        }
    }
}
