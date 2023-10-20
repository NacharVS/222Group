using UnitsDrafts;
namespace UnitsDrafts
{
    internal class Ratusha
    {
        public Bishop CreateBishop() 
        {
            ++Stat.BishopQuant;
            ++Stat.BishopQuant;
            ++Stat.BishopQuant;
            return new Bishop(); 
        }

        public Peasant CreatePeasant() 
        {
            ++Stat.PeasantQuant;
            ++Stat.PeasantQuant;
            ++Stat.PeasantQuant;
            ++Stat.PeasantQuant;
            return new Peasant();
        }
    }
}
