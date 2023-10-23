using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class TownHall
    {
        public Bishop CreateBishop()
        {
            Statistics.BishopCount++;
            return new Bishop();
        }

        public Peasant CreatePeasant()
        {
            Statistics.PeasantCount++;
            return new Peasant();
        }
    }
}
