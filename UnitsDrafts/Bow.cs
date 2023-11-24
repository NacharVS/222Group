using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Bow : Weapon
    {
        private int _bowlvl;
        public int BOWLVL
        {
            get { return _bowlvl; }
            set { _bowlvl = value; }
        }
        public Bow() : base("Luk", 4, 9, 4, 75, 300, true, 0)
        {
            BOWLVL = 0;
        }
        public void BowUpgrade()
        {
            if (BOWLVL < 6) 
            {
                BOWLVL++;
                MinDamage += 4;
                MaxDamage += 4;
                AttackSpeed += 1;
                Accuracy += 3;
                Durability += 50;
                Console.WriteLine($"BowLVL: {BOWLVL} Name:{WepName} MinDMG: {MinDamage} MaxDMG: {MaxDamage} " +
                                  $"AttackSpeed: {AttackSpeed} Accuracy: {Accuracy} Durability: {Durability}");
            }
            else
            {
                Console.WriteLine("Уровень прокачки лука максимальный");
            }
        }
    }
}
