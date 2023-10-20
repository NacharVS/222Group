using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal static class Barracs
    {
        static Footman CreateWarrior()
        {
            Statistics.FootmansCount++;
            Footman footman = new Footman();
            return footman;
        }
        static Archer CreateArch()
        {
            Statistics.ArchersCount++;
            Archer archer = new Archer();
            return archer;
        }

        
    }
}
