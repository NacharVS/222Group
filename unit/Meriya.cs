using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit
{
    internal class Meriya
    {
        public Bishop CreateBishop()
        {
            Stat.BishopQuant+=1;
            Stat.LiveQuant+=1;
            return new Bishop();
        }
        public Peasant CreatePeasant()
        {
            Stat.PeasantQuant+=1;
            Stat.LiveQuant += 1;
            return new Peasant();
        }
    }
}
