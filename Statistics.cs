namespace UnitsDrafts
{
    internal static class Statistics
    {
        public static int FootmansCount { get; set; } = 0;
        public static int ArchersCount { get; set; } = 0;
        public static int BishopCount { get; set; } = 0;
        public static int PeasantCount { get; set; } = 0;

        public static int LiveCount = 0;

        public static int KilledCount = 0;

        public static void ShowStatistics()
        {
            Console.WriteLine($" Количество Bishop:{BishopCount} \n Количество Peasant:{PeasantCount} \n Количество Archer:{ArchersCount} \n Количество Footman:{FootmansCount}");
            Console.WriteLine($" Живых:{LiveCount} \n Мертвых:{KilledCount}");
        }
    }
}
