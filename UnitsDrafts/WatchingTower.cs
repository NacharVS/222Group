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
                Console.WriteLine("Лучник добавлен в башню.");
            }
            else
            {
                Console.WriteLine("Невозможно добавить лучника. Башня заполнена.");
            }
        }

        public void UpgradeTower()
        {
            maxArcherCount = 10;
            Console.WriteLine("Башня улучшена. Максимальное количество лучников: " + maxArcherCount);
        }
    }
}
