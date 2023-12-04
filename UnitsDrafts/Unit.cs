namespace UnitsDrafts
{
    internal class Unit 
    {
        public delegate void HealthChangedDelegate(int health, int diff);

        public Action action;
        private int _damage;
        private int _defence;
        private string _name;
        private int _currentHealth;
        private int _maxHealth;
        private int _speed;

        public Unit(string name, int maxHealth, int defence, int damage,
            int speed)
        {
            _damage = damage;
            _defence = defence;
            _name = name;
            _currentHealth = maxHealth;
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

        public int Health
        {
            get { return _currentHealth; }
            set 
            { 
                if(value > MaxHealth )
                {
                    _currentHealth = MaxHealth;
                }
                else if (value < 0)
                {
                    _currentHealth = 0;
                }
                else
                {
                    int diff = _currentHealth - value;
                    if(diff > 0)
                    {
                        _currentHealth = value;
                        HealthDecreasedEvent?.Invoke(_currentHealth, diff);
                    }
                    else
                    {
                        _currentHealth = value;
                        HealthIncreasedEvent?.Invoke(_currentHealth, Math.Abs(diff));

                    }
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
            Console.WriteLine($"Name:{_name} Health: {_currentHealth}/{_maxHealth} Defence: {_defence} " );

        }

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;

    }
}
