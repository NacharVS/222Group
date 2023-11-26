using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitsDrafts
{
    internal class Peasant : BaseOfUnits
    {
        public static List<ArcheryRange> ArcheryRanges = new List<ArcheryRange>();
        public static List<FootmansTrainingGround> FootmansTrainingGrounds = new List<FootmansTrainingGround>();
        public Peasant() : base("Peasant", 100, 100, 0, 0)
        {
        }

        public void BuildArcheryRange()
        {
            ShowCount.BuildingQuant += 1;
            ArcheryRanges.Add(new ArcheryRange());
        }

        public void BuildFootmansTrainingGroind()
        {
            ShowCount.BuildingQuant += 1;
            FootmansTrainingGrounds.Add(new FootmansTrainingGround());
        }

    }
}
