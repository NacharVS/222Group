using UnitsDrafts;
namespace UnitsDrafts
{
    internal class Barracs
    {
        public Footman CreateFootman()
        {
            ++Stat.FootmanQuant;
            ++Stat.FootmanQuant;
            return new Footman();
        }

        public Archer CreateArcher()
        {
            ++Stat.ArcherQuant;
            return new Archer();
        }
    }
}
