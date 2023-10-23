using System.Threading;
using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _defence;

        public Footman(string name, int maxHealth, int speed, int damage, bool armor)
            : base(name, maxHealth, speed, armor, damage)
        {
            
        }

        public Footman() : base("Footman", 60, 10, true, 13)
        {
        }

        public int RageMode
        {
            get { return Health; }
            set
            {
                if (value < 40 && value > 0)
                {
                    Damage = Damage + (Damage * 50 / 100);
                }

            }
        }


        public override void BaseInfo()
        {
            Console.WriteLine($"Name:{base.Name} Health: {base.Health}/{base.MaxHealth} Speed: {base.Speed} Damage: {Damage}");
        }
        
            

    }
}
