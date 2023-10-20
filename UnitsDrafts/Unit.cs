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
        private int _damage;

        public Unit(string name, int maxHealth, int speed, bool armor, int damage)
        {
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _speed = speed;
            _armor = armor;
            _damage = damage;
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

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public int Health
        {
            get { return _health; }
            set 
            { 
                if(value < 40 && value > 0)
                {
                    Damage = Damage + (Damage * 50 / 100);      
                } 
                if(value < 0)
                {
                    _health = 0;
                }
                else
                    _health = value;
                
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
