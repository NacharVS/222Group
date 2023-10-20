using UnitsDrafts;
namespace UnitsDrafts
{
    internal class Stat
    {
        public static int BishopQuant = 0;
        public static int PeasantQuant = 0;
        public static int FootmanQuant = 0;
        public static int ArcherQuant = 0;

        public static void ShowInfo()
        {
            Console.WriteLine($"{FootmanQuant} пехотинцев");
            Console.WriteLine($"{PeasantQuant} крестьян");
            Console.WriteLine($"{BishopQuant} магов");
            Console.WriteLine($"{ArcherQuant} лучников");
        }
    }
}
