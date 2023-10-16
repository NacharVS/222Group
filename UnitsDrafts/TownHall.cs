using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class TownHall
    {
        public Bishop CreateBishop()
        {
            Statistics.BishopsCount++;
            return new Bishop();
        }

        public Peasant CreatePeasant()
        {
            Statistics.PeasantsCount++;
            return new Peasant();
        }
    }
}
