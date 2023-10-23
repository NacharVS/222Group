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

        public virtual void Moving()
        {
            Console.WriteLine($"{Name} is moving with {Speed} speed");
        }

        public virtual void BaseInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Defense: {Defense} Speed {Speed}");
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
            double def_damage = Damage - unit.Defense;
            if (def_damage < 0)
            {
                def_damage = 0;
            }
            Console.WriteLine($"{Name} dealed {def_damage} damage");
            unit.Health = unit.Health - def_damage;
            if (unit.Health <= 0)
            {
                Console.WriteLine("Юнит убит");
            }
            else
            {
                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
            }
        }

    }
}