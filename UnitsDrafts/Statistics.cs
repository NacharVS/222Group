namespace UnitsDrafts
{
    internal static class Statistics
    {
        public static int FootmansCount { get; set; } = 0;
        public static int ArchersCount { get; set; } = 0;
        public static int BishopCount { get; set; } = 0;
        public static int PeasantCount { get; set; } = 0;

        public static void ShowStatistics()
        {
            Console.WriteLine($"{FootmansCount} {ArchersCount}");
        }
    }
}
