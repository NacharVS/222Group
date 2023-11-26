namespace UnitsDrafts
{
    internal class Barracs
    {
        public Footman CreateFootman()
        {
            Random random = new Random();
            Statistics.FootmanCount++;
            return new Footman("Name", random.Next(50, 60), random.Next(5, 10), random.Next(5, 15), random.Next(1, 4));
        }

        public Archer CreateArcher()
        {
            Random random = new Random();
            Statistics.ArcherCount++;
            return new Archer("Name", random.Next(30, 45), random.Next(5, 10), random.Next(10, 15));
        }
    }
}
