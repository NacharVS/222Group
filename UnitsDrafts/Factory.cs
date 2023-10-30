using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Factory
    {
        public WatchingTower CreateWTower()
        {
            Statistics.TowerCount++;
            WatchingTower WT = new WatchingTower(2000, 0, 1, 0);
            return WT;

        }
    }
}
