using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts
{
    internal class Archer : Unit
    {
        public Archer() : base("Archer", 40, 11, false, 9)
        {
        }
        public int RageMode
        {
            get { return Health; }
            set
            {
                if (value < 40 && value > 0)
                {
                    Console.WriteLine("ЖИДКИЙ ПОНОС Я В ЯРОСТЕ");
                    Speed += 4;
                }

            }
        }
        public override void BaseInfo()
        {
            Console.WriteLine($"Name:{base.Name} Health: {base.Health}/{base.MaxHealth} Speed: {base.Speed}");
        }

    }
}
