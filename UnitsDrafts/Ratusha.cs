using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Ratusha
    {
        public Bishop CreateBishop() 
        {
            ++Stat.BishopQuant;
            ++Stat.BishopQuant;
            ++Stat.BishopQuant;
            return new Bishop(); 
        }

        public Peasant CreatePeasant() 
        {
            ++Stat.PeasantQuant;
            ++Stat.PeasantQuant;
            ++Stat.PeasantQuant;
            ++Stat.PeasantQuant;
            return new Peasant();
        }
    }
}
