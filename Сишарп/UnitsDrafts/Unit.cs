namespace UnitsDrafts
{
    internal class Unit
    {
        private int _damage;
        private int _defence;
        private string _name;
        private int _health;
        private int _maxHealth;
        private int _speed;
        public Weapon weapon;

        public Unit(string name, int maxHealth, int defence, int damage,
            int speed)
        {
            _damage = damage;
            _defence = defence;
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _speed = speed;
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual int Health
        {
            get { return _health; }
            set
            {
                if (value > 30)
                {
                    _health = 30;
                }
                else if (value < 0)
                {
                    _health = 0;
                }
                else
                    _health = value;
                while (Health < Health / 100 * 40)
                {
                    _damage = _damage + _damage / 100 * 50;
                }
            }
        }

        public int Defence
        {
            get { return _defence; }
            set { _defence -= _damage; }
        }

        public int MaxHealth { get => _maxHealth; }

        public void Moving()
        {
            Console.WriteLine($"{_name} is moving with {_speed} speed");
        }

        public virtual void BaseInfo()
        {
            Console.WriteLine($"Name:{_name} Health: {_health}/{_maxHealth} Defence: {_defence} ");
        }

    }
}

