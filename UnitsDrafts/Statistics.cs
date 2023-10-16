namespace UnitsDrafts
{
    internal static class Statistics
    {
        public static int FootmansCount { get; set; } = 0;
        public static int ArchersCount { get; set; } = 0;

        public static int BishopsCount { get; set; } = 0;

        public static int PeasantsCount { get; set; } = 0;

        public static void ShowStatistics()
        {
            Console.WriteLine($"Пехотинцы:{FootmansCount} Лучники:{ArchersCount} Клерики: {BishopsCount} Жители: {PeasantsCount}");
        }
    }
}
