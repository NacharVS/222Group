﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit.items;

namespace UnitsDrafts.unit.items
{
    internal class Sword : Weapon
    {
        double CritDamage = 0.5;
        double CritChance = 20;
        public Sword() : base(2, 7, 8, 80) 
        {

        }
    }
}
