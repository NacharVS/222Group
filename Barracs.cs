namespace UnitsDrafts
{
    internal class Barracs
    {
        public Footman CreateFoot()
        {
            Statistics.FootmansCount++;
            Footman footman = new Footman();
            return footman;

        }

        public Archer CreateArch()
        {
            Statistics.ArchersCount++;
            Archer archer = new Archer();
            return archer;

        }
    }
}
