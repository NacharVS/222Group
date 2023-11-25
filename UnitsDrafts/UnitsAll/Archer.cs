using System.Xml.Linq;

namespace UnitsDrafts.UnitsAll
{
    internal class Archer : Unit
    {
        private int _damage;
        private int _speed;
        public Archer(string name, int maxHealth, int speed, int damage, int defence)
            : base(name, maxHealth, speed, defence, damage)
        {
            _speed = speed;
            _damage = damage;
        }

        public Archer() : base("Archer", 40, 11, 5, 15)
        {
            _speed = 11;
            _damage = 8;
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        

        public override void BaseInfo()
        {
            if (Health < 16)
            {
                _speed = 11;
                _speed = _speed + 4;

            }
            else
            {
                _speed = 11;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Name: {Name}|");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Health: {Health}/{MaxHealth}");
            Console.ResetColor();
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"|Speed: {_speed}");
            Console.ResetColor();

        }
    }
}
