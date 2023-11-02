﻿namespace UnitsDrafts
{
    internal class Unit 
    {
        private int _damage;
        private int _defence;
        private string _name;
        private double _health;
        private double _maxHealth;
        private int _speed;

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
