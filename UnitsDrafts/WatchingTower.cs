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
            int ArcherCount = 3;
            foreach (Archer unit in units)
            {
                unit.BaseInfo();
            }
            Console.WriteLine("Если хочешь улучшить башню нажми 1");
            for (int i = 1; i < 8; i++) 
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 1 )
                {
                    units.Add(archer1);
                    foreach (Archer unit in units)
                    {
                        unit.BaseInfo();
                    }
                    Console.WriteLine($"Башня улучшена. Макс число лучников: {ArcherCount + i} ");
                    Console.WriteLine("Если хочешь улучшить башню нажми 1");
                }
            }
            Console.WriteLine("Максимальное улучшение");
        }
    }
}
