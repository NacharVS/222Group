using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class TownHall
    {
        public Bishop CreateBishop(string name, int health, int speed, int mana)
        {
            return new Bishop(name, health, speed, mana);
        }

        public Peasant CreatePeasant(string name, int health, int speed)
        {
            return new Peasant(name, health, speed);
        }
    }
}
