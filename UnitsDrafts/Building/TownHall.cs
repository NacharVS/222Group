using UnitsDrafts;

namespace UnitsDrafts
{
    internal class TownHall
    {
        public Bishop CreateBishop()
        {
            Statistics.BishopCount++;
            return new Bishop();
        }

        public Peasant CreatePeasant()
        {
            Random rnd = new Random();
            Statistics.PeasantCount++;
            return new Peasant();
        }
    }
}
