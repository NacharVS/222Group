using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace UnitsDrafts
{

    internal class Archer : Unit
    {               
        private int _speed;

        public Archer(string name, int maxHealth, int defence, int damage, int speed) : base(name, maxHealth, defence, damage, speed)
        {
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public override void BaseInfo()
        { 
            if (Health < 16) 
            {
                _speed += 4;
            }
            else
            {
                _speed = 11;
            }
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Speed: {_speed} ");
        }
    } 
}
