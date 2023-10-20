using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class WatchingTower
    {
        public void Garrison() 
        {
            Archer archer1 = new Archer();
            List<Unit> units = new List<Unit>();
            units.Add(archer1);
            units.Add(archer1);
            units.Add(archer1);
            foreach (Archer unit in units)
            {
                unit.BaseInfo();
            }
            Console.WriteLine("Если хочешь улучшить башню нажми 1");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                units.Add(archer1);
                foreach (Archer unit in units)
                {
                    unit.BaseInfo();
                }
            }          
        }
    }
}
