using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsDrafts.Processes;
using UnitsDrafts.UnitsAll;

namespace UnitsDrafts.BuilsingsAll
{
    internal class MaternityHospital
    {
        public Peasant CreatePeasant()
        {
            ShowStatisticProcess.PeasantQuant += 1;
            ShowStatisticProcess.LiveQuant += 1;
            Random random = new Random();
            return new Peasant();
        }
    }
}
