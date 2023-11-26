using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class FootmansTrainingGround : BaseOfUnits
    {
        public static List<Footman> footmanList = new List<Footman>();

        public FootmansTrainingGround() : base("Footmans training ground", 500, 500, 0, 0)
        {
        }

        public void CreateFootman()
        {
            ShowCount.FootmanQuant += 1;
            ShowCount.LiveQuant += 1;
            footmanList.Add(new Footman());
        }
    }
}
