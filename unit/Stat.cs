using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit
{
    internal static class Stat
    {
        public static int BishopQuant = 0;
        public static int PeasantQuant = 0;
        public static int ArcherQuant = 0;
        public static int FootmanQuant = 0;
        public static int LiveQuant = 0 - KilledQuant;
        public static int KilledQuant = 0;
        public static  void StatInfo()
        {
            Console.WriteLine($" Количество Bishop:{BishopQuant} \n Количество Peasant:{PeasantQuant} \n Количество Archer:{ArcherQuant} \n Количество Footman:{FootmanQuant}");
            Console.WriteLine($" Живых:{LiveQuant} \n Мертвых:{KilledQuant}");
        }
    }
}
