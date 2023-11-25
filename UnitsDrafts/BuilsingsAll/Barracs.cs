using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsDrafts.Processes;
using UnitsDrafts.UnitsAll;

namespace UnitsDrafts.BuilsingsAll
{
    internal class Barracs
    {
        public Footman CreateFootman()
        {
            ShowStatisticProcess.FootmanQuant += 1;
            ShowStatisticProcess.LiveQuant += 1;
            Random random = new Random();
            return new Footman();
        }
        public Archer CreateArcher()
        {
            ShowStatisticProcess.ArcherQuant += 1;
            ShowStatisticProcess.LiveQuant += 1;
            Random random = new Random();
            return new Archer();
        }
    }

}
