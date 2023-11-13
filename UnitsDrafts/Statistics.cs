namespace UnitsDrafts
{
    internal class Statistics
    {
        public static int FootmanCount { get; set; } = 0;
        public static int ArcherCount { get; set; } = 0;
        public static int BishopCount { get; set; } = 0;
        public static int PeasantCount { get; set; } = 0;

        public static void ShowStatistics()
        {
            Console.WriteLine($"Создано копейщиков: {FootmanCount}\nСоздано лучников: {ArcherCount}\nСоздано лекарей: {BishopCount}\nСоздано крестьян: {PeasantCount}");
        }
    }
}

