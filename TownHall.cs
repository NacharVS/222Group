using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class TownHall
    {
        public Bishop CreateBis()
        {
            Statistics.BishopCount++;
            Bishop bishop = new Bishop();
            return bishop;

        }

        public Peasant CreatePeas()
        {
            Statistics.PeasantCount++;
            Peasant peasant = new Peasant();
            return peasant;

        }
    }
}
