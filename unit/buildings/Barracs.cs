using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit.units;

namespace unit.buildings
{
    internal class Barracs
    {
        public  Footman CreateFootman()
        {
            Stat.FootmanQuant += 1;
            Stat.LiveQuant += 1;
            Random random = new Random();
            return new Footman("Footman", random.Next(50,80),11,10, 7,random.Next(1,4)) ;
        }
        public Archer CreateArchcer()
        {
            Stat.ArcherQuant += 1;
            Stat.LiveQuant += 1;
            return new Archer();
        }
    }
}
