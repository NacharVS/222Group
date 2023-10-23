using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Statistics
    {
        public static int FootmanCount { get; set; } = 0;
        public static int ArcherCount { get; set;} = 0;
        public static int BishopCount { get; set; } = 0;
        public static int PeasantCount { get; set; } = 0;

        public static void ShowStatistics()
        {
            Console.WriteLine($"{FootmanCount} - Footman {ArcherCount} - Archer {BishopCount} - Bishop {PeasantCount} - Peasant");
        }
    }
}
