using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts
{
    internal class Archer : Unit
    {

        public Archer(string name, int maxHealth, int speed, bool armor) : base(name, maxHealth, speed, armor)
        {
        }
        public Archer() : base("archer", 40, 11, false)
        {
        }
        public int RageMode
        {
            get { return Health; }
            set
            {
                if (value < 40 && value > 0)
                {
                    Console.WriteLine(" Я В ЯРОСТЕ");
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
