using System.Data;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Archer : Unit
    {
        int Count = 0;
        public Archer() : base("Archer", 40, 5,15,15)
        {
            if (Health < MaxHealth * 0.4)
            {
                Speed += 4;
            }
        }
    }
}


