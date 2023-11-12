using UnitsDrafts.Items;

namespace UnitsDrafts
{
    internal class Unit
    {
        private string _name;
        private double _health;
        private double _defense;
        private double _maxHealth;
        private double _speed;
        private double _damage;
        public bool _alive = true;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public virtual double Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public double Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public virtual double Health
        {

            get { return _health; }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                    Alive = false;
                }
                else
                    _health = value;
            }
        }

        public double MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }
        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
        }

        public virtual void Moving()
        {
            if (Alive)
            {
                Console.WriteLine($"{Name} is moving with {Speed} speed");
            }
            else
            {
                Console.WriteLine($"{Name} dead");
            }
        }
        public virtual void BaseInfo()
        {
            if(Alive)
            {
                Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Defense: {Defense} Speed {Speed}");
            }
            else
            {
                Console.WriteLine($"{Name} dead");
            }
        }
        public Unit(string name, double maxHealth, double defense, double damage, double speed)
        {
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _defense = defense;
            _damage = damage;
            _speed = speed;
        }
        public virtual void DealDamage(Unit unit)
        {
            if (Alive)
            {
                if (unit.Alive)
                   {
                    double def_damage = Damage - unit.Defense;
                    if (def_damage < 0)
                        {
                         def_damage = 0;
                        }
                    else
                    {
                        Console.WriteLine($"{Name} нанес {def_damage} урона");
                        unit.Health = unit.Health - def_damage;
                        if (unit.Health <= 0)
                            {
                            Console.WriteLine($"{unit.Name} убит");
                            unit.Alive = false;
                            }
                        else
                            {
                            Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
                            }
                        }
                    }
                else
                {
                    Console.WriteLine("Атакованный юнит уже мёртв");
                }

            }
            else { Console.WriteLine("Юнит не может атаковать - он мертв"); }
        }

    }
}