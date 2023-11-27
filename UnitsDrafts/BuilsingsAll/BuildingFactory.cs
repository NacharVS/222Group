using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsDrafts.Processes;
using UnitsDrafts.UnitsAll;

namespace UnitsDrafts.BuilsingsAll
{
    internal class BuildingFactory
    {
        static public Barracs CreateBarracs()
        {
            ShowStatisticProcess.BarracsQuant += 1;
            ShowStatisticProcess.BuildingQuant += 1;
            Random random = new Random();
            return new Barracs();
        }
        static public MaternityHospital CreateMama()
        {
            ShowStatisticProcess.MamaQuant += 1;
            ShowStatisticProcess.BuildingQuant += 1;
            Random random = new Random();
            return new MaternityHospital();
        }
        static public TownHall CreateTownHall()
        {
            ShowStatisticProcess.TownHallQuant += 1;
            ShowStatisticProcess.BuildingQuant += 1;
            Random random = new Random();
            return new TownHall();
        }
        static public WatchingTower CreateTowers()
        {
            ShowStatisticProcess.TowersQuant += 1;
            ShowStatisticProcess.BuildingQuant += 1;
            Random random = new Random();
            return new WatchingTower();
        }
    }
}
