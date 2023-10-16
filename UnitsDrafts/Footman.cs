using System.Threading;
using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _damage;
        private int _defence;

        public Footman(string name, int maxHealth, int speed, int damage, bool armor)
            : base(name, maxHealth, speed, armor)
        {
            _damage = damage;
        }

        public Footman() : base("Footman", 60, 10, false)
        {
            _damage = 13;
            _defence = 2 / 10;
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }



        public void RageMode(Footman ft12)
        {
            if (Health < MaxHealth * 40 / 100)
            {
                Damage = Damage + (Damage * 50 / 100);
            }
        }

        public override void BaseInfo()
        {
            Console.WriteLine($"Name:{base.Name} Health: {base.Health}/{base.MaxHealth} Speed: {base.Speed} Damage: {Damage}");
        }



        public void InflictDamage(Unit unit)
        {
            if (unit.Speed >= 15)
            {
                Console.WriteLine("СЛКШИМ БИСТРо");
                return;            
            }
            else if (Armor == true)
            {
                unit.Health = unit.Health - (_damage * 80 / 100);
            }
            else
            {
                unit.Health -= _damage;
            }
        } 
        
            

    }
}
