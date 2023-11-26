using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class ShowCount
    {        
        public static int PeasantQuant = 0;
        public static int ArcherQuant = 0;
        public static int FootmanQuant = 0;
        public static int LiveQuant = 0;
        public static int KilledQuant = 0;
        public static int BuildingQuant = 1;
        public static void ShowQuantity()
        {
            Console.WriteLine($"Живых:{LiveQuant} | Мертвых:{KilledQuant}");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"Строителей:{PeasantQuant}");
            Console.WriteLine($"Лучников:{ArcherQuant}");
            Console.WriteLine($"Воинов:{FootmanQuant}");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"Построек:{BuildingQuant}"); 
        }
    }
}
