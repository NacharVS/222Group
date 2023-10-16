namespace UnitsDrafts
{
    internal class Barracs 
    {
        public Footman CreateFootman()
        {
            Statistics.FootmansCount++;
            return new Footman();
        }

        public Archer CreateArcher()
        {
            Statistics.ArchersCount++;
            return new Archer();
        }
    }
}
