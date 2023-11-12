using unit.items;
using UnitsDrafts.unit.items;

namespace UnitsDrafts
{
    internal class Unit 
    {

        private int _damage;
        private int _defence;
        private string _name;
        private double _health;
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
            get { return _health; }
            set 
            { 
                if(value > 30 )
                {
                    _health = 30;
                }
                else if (value < 0)
                {
                    _health = 0;
                }
                else
                    _health = value;
            }
        }

        public int Defence
        {
            get { return _defence; }
            set { _defence -= _damage; }
        }
        public virtual void DealDamage(Unit unit)
        {
            int f = Convert.ToInt32(Console.ReadLine());
            if (f == 1)
            {
                _weapon = new Sword();
            }
            if (f == 2)
            {
                _weapon = new Axe();
            }
            if (f == 3)
            {
                _weapon = new Mace();
            }
            if (f == 4)
            {
                _weapon = new Bow();
            }
            double damage = _weapon.Hit(unit);
            if (Alive)
            {
                if (Stun)
                {
                    Console.WriteLine("Юнит оглушен, атака невозможна!");
                }
                else
                {
                    if (unit.Alive)
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
                        Console.WriteLine("Нельзя бить труп");
                    }
                }

            }
            else { Console.WriteLine("Юнит не может атаковать, так как мёртв"); }
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


    }
}
