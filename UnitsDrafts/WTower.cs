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
        private int _ArchersInTower;

        public WatchingTower(int TowerHealth, int TowerDamage, int lvl, int archersInTower)
        {
            _TowerHealth = 1300;
            _TowerDamage = 27;
            _lvl = 1;
            _ArchersInTower = 3;
        }

        public int AIT
        {
            get { return _ArchersInTower; }
            set { _ArchersInTower = value; }
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
        Archer archer2 = new Archer();

        public override void BaseInfo()
        {
            Console.WriteLine($"Name:{base.Name} Health: {base.Health}/{base.MaxHealth} Speed: {base.Speed}");
        }

        public void Upgradee()
        {
            for (AIT = AIT; AIT > archerTower.Count(); archerTower.Add(archer2))
            {
            }
            if (archerTower.Count() <= AIT && LVL != 8)
            {
                TWhealth += 100;
                TWDamage += 9;
                archerTower.Add(archer2);
                AIT = AIT + 1;
                LVL++;
                Console.WriteLine($"Башня прокачалась до: {LVL}");
                Console.WriteLine($"Количество лучников увеличилось до: {archerTower.Count()}");
            }
            else
            {
                Console.WriteLine("Максимальный лвл уже прокачен!");
                return;
            }
        }

        public void TowerInfo()
        {
            Console.WriteLine($"Health: {TWhealth} Damage: {TWDamage} Lvl: {LVL} Count: {AIT}");
        }
    }
}