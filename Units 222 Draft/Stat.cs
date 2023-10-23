using System;
using Units_222_Draft.units;

namespace UnitsDrafts
{
    internal class Stat
    {
        public static int BishopQuantity = 0;
        public static int PeasantQuantity = 0;
        public static int FootmanQuantity = 0;
        public static int ArcherQuantity = 0;
        public static int CorpseQuantity = 0;
        public static int AliveQuantity = 0;
        public static List<Unit> units = new List<Unit>();
        public static void ShowInfo()
        { 
            Console.WriteLine($"{FootmanQuantity} Пехотинцов");
            Console.WriteLine($"{ArcherQuantity} Лучников");
            Console.WriteLine($"{BishopQuantity} Магов");
            Console.WriteLine($"{PeasantQuantity} Крестьян");
            Console.WriteLine($"{AliveQuantity - CorpseQuantity} Живо");
            Console.WriteLine($"{CorpseQuantity} Убито");
        }
        
    }

}
