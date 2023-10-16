using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Townhall
    {
        public Bishop SpawnBishop()
        { 
            ++Stat.BishopQuantity;
            ++Stat.AliveQuantity;
            return new Bishop();
        }
        public Peasant SpawnPeasant()
        {
            ++Stat.PeasantQuantity;
            ++Stat.AliveQuantity;
            return new Peasant();
        }
    }
}
