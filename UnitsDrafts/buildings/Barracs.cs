using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Barracs
    {
        public Footman CreateFootman()
        {

            Random rnd = new Random();
            Statistics.FootmanCount++;
            return new Footman();
        }
        public Archer CreateArcher()
        {
            Statistics.ArcherCount++;
            return new Archer();
        }
    }
}
