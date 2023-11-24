using System.Net.WebSockets;
using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts
{
    internal class Unit
    {
        private string _name;
        private int _health;
        private int _maxHealth;
        private int _speed;
        private bool _armor;
        public Weapon Weapon;
        private bool _stunned;

        public Unit(string name, int maxHealth, int speed, bool armor, Weapon weapon)
        {
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _speed = speed;
            Weapon = weapon;
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = ""; }
        }

        public int Health
        {
            get { return _health; }
            set 
            {
                if(value < 0)
                {
                    _health = 0;
                }
                else
                {
                    _health = value;
                }
                
            }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }

        public bool Armor
        {
            get { return _armor; }
            set { _armor = false; }
        }

        public void Moving()
        {
            Console.WriteLine($"{_name} is moving with {_speed} speed");
        }

        public virtual void BaseInfo()
        {
            Console.WriteLine($"Name:{_name} Health: {_health}/{_maxHealth} Speed: {Speed}" );
        }

        public void Death()
        {
            if ( _health == 0 ) 
            {
                Console.WriteLine("Персонаж умер");
            }
        }
    }
}
