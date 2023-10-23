using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace unit
{
    internal class WatchingTowers
    {
        List<Unit> Garrison = new List<Unit>() { new Archer(), new Archer(), new Archer()};
        static int LevelCount = 0;
         
        
            
            
        public void ShowTowerUnits()
        {
            Console.WriteLine();
            Console.WriteLine("Стрелки в башне");
            foreach (var unit in Garrison)
            {
               unit.BaseInfo();
            }
            
        }
        public void TowerDamage()
        {

        }
        public void Upgrade()
        {
            Garrison.Add(new Archer());
            
            LevelCount++;
            Console.WriteLine($"Уровень башни был повышен, текущий уровень {LevelCount}");
        }
        public void UnitsCount()
        {
            Console.WriteLine($"Уровень башни:{LevelCount}");
        }
    }
}
