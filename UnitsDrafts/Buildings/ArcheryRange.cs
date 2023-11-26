using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitsDrafts
{
    internal class ArcheryRange : BaseOfUnits
    {
        public static List<Archer> archerList = new List<Archer>();
        public ArcheryRange() : base("Archery Range", 100, 100, 0, 0)
        {
        }

        public void CreateArcher()
        {
            ShowCount.ArcherQuant += 1;
            ShowCount.LiveQuant += 1;
            archerList.Add(new Archer());
        }
    }
}
