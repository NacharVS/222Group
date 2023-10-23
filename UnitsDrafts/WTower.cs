using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        int lvlr = 3;
        int lvlt = 1;

        public List<Archer> archerTower = new List<Archer>();
        Archer archer2 = new Archer();

        public override void BaseInfo()
        {
            Console.WriteLine($"Name:{base.Name} Health: {base.Health}/{base.MaxHealth} Speed: {base.Speed}");
        }

        public void Upgradee()
        {
            for (lvlr = lvlr; lvlr > archerTower.Count(); archerTower.Add(archer2))
            {
            }
            if (archerTower.Count() <= lvlr)
            {
                archerTower.Add(archer2);
                lvlr = lvlr + 1;
                lvlt = lvlr - 2;
                Console.WriteLine($"Башня прокачалась до: {lvlt}");
                Console.WriteLine($"Количество лучников увеличилось до: {archerTower.Count()}");
            }
        }

        public void TowerInfo()
        {
            Console.WriteLine($"Health: {TWhealth} Damage: {TWDamage} Lvl: {lvlt}");
        }
    }
}