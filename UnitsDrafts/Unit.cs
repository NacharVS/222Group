using unit.items;
using UnitsDrafts.unit.items;

namespace UnitsDrafts
{
    internal class Unit 
    {
        public void GiveDamageMethod1(Unit unit)
        {
            double damage = _weapon.Hit(unit);
            if (Alive)
            {
                if (Stun)
                {
                    Console.WriteLine("Юнит оглушен - он не может атаковать. Damage = 0");
                }
                else
                {
                    if (unit.Alive)
                    {
                        if (_weapon.Alive)
                        {
                            Console.WriteLine($"{Name} нанес {damage} урона");
                            unit.Health = unit.Health - damage;
                            Console.WriteLine($"У вас {unit.Health} здоровья");
                            if (unit.Health <= 0)
                            {
                                Console.WriteLine($"{unit.Name} убит");
                                unit.Alive = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("оружие сломано");
                        }
                    }
                    else
                    {
                        Console.WriteLine("труп");
                    }
                }

            }
        }
        public delegate void HealthChangedDelegate(double health, double diff);
        public delegate void GiveDamageDelegate(Unit unit);
        public GiveDamageDelegate giveDamage;
        private int _damage;
        private int _defence;
        private string _name;
        private double _health;
        private double _currentHealth;
        private double _maxHealth;
        private int _speed;
        public bool _stun = false;
        public bool _alive = true;
        public bool _bloodloss = false;
        public Weapon _weapon;

        public Unit(string name, double maxHealth, int defence, int damage,
            int speed, double health)
        {
            _damage = damage;
            _defence = defence;
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _speed = speed;
        }

        public bool BloodLoss
        {
            get { return _bloodloss; }
            set { _bloodloss = value; }
        }
        public bool Stun
        {
            get { return _stun; }
            set { _stun = value; }
        }

        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
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
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Health
        {
            get { return _currentHealth; }
            set
            {
                if (value > MaxHealth)
                {
                    _currentHealth = MaxHealth;
                }
                else if (value < 0)
                {
                    _currentHealth = 0;
                }
                else
                {
                    double diff = _currentHealth - value;
                    if (diff > 0)
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
        public virtual void GiveDamage(Unit unit)
        {
            giveDamage = GiveDamageMethod1;
            giveDamage(unit);
        }

        public double MaxHealth { get => _maxHealth; }

        public void Moving()
        {
            Console.WriteLine($"{_name} is moving with {_speed} speed");
        }

        public virtual void BaseInfo()
        {
            Console.WriteLine($"Name:{_name} Health: {_health}/{_maxHealth} Defence: {_defence} " );
        }

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;

    }
}
