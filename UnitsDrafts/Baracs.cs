using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal static class Baracs

    {
        public static Footman SozdatPehotintsa()
        {
            Statistics.FootmansCount++;
            Footman footman = new Footman();
            return footman;
        }
        public static Archer SozdatLuchnika()
        {
            Statistics.ArchersCount++;
            Archer archer = new Archer();
            return archer;
        }
    }
}
