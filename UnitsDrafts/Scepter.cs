using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Scepter : Weapon
    {
        private int _sceplvl;
        public Scepter() : base("Skiper", 4, 8, 6, 75, 400, false)
        {
            SCEPLVL = 0;
        }
        public int SCEPLVL
        {
            get { return _sceplvl; }
            set { _sceplvl = value; }
        }
        public void SCEPUpgrade()
        {
            if (SCEPLVL < 6)
            {
                SCEPLVL++;
                MinDamage += 2;
                MaxDamage += 2;
                AttackSpeed += 3;
                Accuracy += 1;
                Durability += 50;
                Console.WriteLine($"SCEPLVL: {SCEPLVL} Name:{WepName} MinDMG: {MinDamage} MaxDMG: {MaxDamage} " +
                                  $"AttackSpeed: {AttackSpeed} Accuracy: {Accuracy} Durability: {Durability}");
            }
            else
            {
                Console.WriteLine("Уровень прокачки лука максимальный");
            }
        }
    }
}
