using System;
using Units_222_Draft.Stats;
using Units_222_Draft.units;

namespace UnitsDrafts
{
    internal class Townhall
    {
        
        public Bishop SpawnBishop()
        { 
            ++Stat.BishopQuantity;
            ++Stat.AliveQuantity;
            Stat.units.Add(new Bishop());
            return new Bishop();
        }
        public Peasant SpawnPeasant()
        {
            ++Stat.PeasantQuantity;
            Stat.units.Add(new Peasant());
            ++Stat.AliveQuantity;
            return new Peasant();
        }
    }
}
