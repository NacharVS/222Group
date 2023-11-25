using System.Xml.Linq;
using UnitsDrafts.Toolbox;
using UnitsDrafts.Processes;
using UnitsDrafts.Toolbox;
using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts.UnitsAll
{
    internal class Footman : Unit
    {
        private int _damage;
        private int _defence;
        private int _speed;

        public Footman(string name, int maxHealth, int speed, int damage, int defence)
            : base(name, maxHealth, speed, defence, damage)
        {
            _damage = damage;
            _defence = defence;
            _speed = speed;
            _weapon = new Sword();
        }

        private Weapon _weapon;

        public Footman() : base("Footman", 60, 10, 10, 30)
        {
            _damage = 17;
            _defence = 5;
            _speed = 10;
            _weapon = new Sword();
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }


        public void TakeDamage(int damage)
        {
            int reduceDamage = damage - Defence;
            if (reduceDamage < 0)
                reduceDamage = 0;

            Health -= reduceDamage;
        }

        public override void BaseInfo()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Name: {Name} | ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Health: {Health}/{MaxHealth}");
            Console.ResetColor();
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"Damage: {Damage}");
            Console.ResetColor();
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Speed: {Speed}");
            Console.ResetColor();
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"Defence: {Defence}");
            Console.ResetColor();
            Console.WriteLine(" | ");

        }


    }
}
