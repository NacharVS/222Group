using System;
using Units_222_Draft.units;

namespace UnitsDrafts
{
    internal class Barracs
    {
        public Footman SpawnFootman() 
        {
            ++Stat.FootmanQuantity;
            Stat.units.Add(new Footman());
            ++Stat.AliveQuantity;
            return new Footman();
        }
        public Archer SpawnArcher()
        {
            ++Stat.ArcherQuantity;
            Stat.units.Add(new Archer());
            ++Stat.AliveQuantity;
            return new Archer();
        }
    }
}
