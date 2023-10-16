using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit
{
    internal class Barracs
    {
        public  Footman CreateFootman()
        {
            Stat.FootmanQuant += 1;
            Stat.LiveQuant += 1;
            Random random = new Random();
            return new Footman();
        }
        public Archer CreateArchcer()
        {
            Stat.ArcherQuant += 1;
            Stat.LiveQuant += 1;
            return new Archer();
        }
    }
}
