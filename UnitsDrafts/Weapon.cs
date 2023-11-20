using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Weapon
    {
        public Weapon(string name, int minDam, int maxDam, int attackSpeed, int accuracy, int durability, bool Bleed)
        {
            WepName = name; MinDamage = minDam;
            MaxDamage = maxDam; AttackSpeed = attackSpeed;
            Accuracy = accuracy; Durability = durability;
            Bleede = Bleed;
        }
        public string WepName { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int AttackSpeed { get; set; }
        public int Accuracy { get; set; }
        public int Durability { get; set; }
        public bool Bleede { get; set; } = false;
    }
    public u tichka(Unit unit)
    {
        
    }

}
