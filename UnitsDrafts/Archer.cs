using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts
{
    internal class Archer : Unit
    {
        public Archer() : base("Archer", 40, 11, false)
        {
        }
        public void RageMode(Archer archer)
        {
            if (Health < MaxHealth * 40 / 100)
            {
                Speed += 4;
            }
        }
        public override void BaseInfo()
        {
            Console.WriteLine($"Name:{base.Name} Health: {base.Health}/{base.MaxHealth} Speed: {base.Speed}");
        }

    }
}
