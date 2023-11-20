using System.Threading;
using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _defence;

        public Footman(string name, int maxHealth, int speed, bool armor)
            : base(name, maxHealth, speed, armor, null)
        {
            
        }

        public Footman() : base("Footman", 60, 10, true, null)
        {
        }


        public override void BaseInfo()
        {
            Console.WriteLine($"Name:{base.Name} Health: {base.Health}/{base.MaxHealth} Speed: {base.Speed}");
        }
        
            

    }
}
