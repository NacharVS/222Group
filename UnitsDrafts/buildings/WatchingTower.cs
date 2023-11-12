using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class WatchingTower
    {
        private List<Archer> archers;
        private int maxArcherCount;

        public int ArcherCount { get { return archers.Count; } }

        public WatchingTower()
        {
            archers = new List<Archer>();
            maxArcherCount = 3;
        }

        public void AddArcher(Archer archer)
        {
            if (archers.Count < maxArcherCount)
            {
                archers.Add(archer);
                Console.WriteLine("В башню был добавлен лучник");
            }
            else
            {
                Console.WriteLine("В башня нет места");
            }
        }

        public void UpTower()
        {
            maxArcherCount =7;
            Console.WriteLine("Башня была улучшена. Количество лучников увеличено до: " + maxArcherCount);
        }
    }
}
