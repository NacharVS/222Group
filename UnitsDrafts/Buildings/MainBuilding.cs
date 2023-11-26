using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class MainBuilding : BaseOfUnits
    {
        public static List<Peasant> peasantList = new List<Peasant>();
        public MainBuilding() : base("Main building", 100, 100, 0, 0)
        {
        }

        public void CreatePeasant()
        {
            ShowCount.PeasantQuant += 1;
            ShowCount.LiveQuant += 1;
            peasantList.Add(new Peasant());
        }
    }
}
