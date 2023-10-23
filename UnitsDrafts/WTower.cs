using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class WatchingTower : Archer
    {
        private int _TowerHealth;
        private int _TowerDamage;
        private int _lvl;

        public WatchingTower(int TowerHealth, int TowerDamage, int lvl)
        {
            _TowerHealth = TowerHealth;
            _TowerDamage = TowerDamage;
            _lvl = lvl;
        }
        public int LVL
        {
            get { return _lvl; }
            set { _lvl = value; }
        }
        public int TWhealth
        {
            get { return _TowerHealth; }
            set { _TowerHealth = value; }
        }
        public int TWDamage
        {
            get { return _TowerDamage; }
            set { _TowerDamage = value; }
        }

        public List<Archer> archerTower = new List<Archer>();
        public List<int> archerLevel = new List<int>();
        public void Upgradee()
        {
            archerTower.Add(Barracs.CreateArch());
            int lastArcher = archerLevel[0];
            if (lastArcher < 10)
            {
                lastArcher += 1;
                Console.WriteLine($"Башня лучниц: {lastArcher}");
            }
        }

        public override void BaseInfo()
        {
            Console.WriteLine($"Health: {TWhealth} Damage: {TWDamage} Lvl: {LVL}");
        }

    }
}