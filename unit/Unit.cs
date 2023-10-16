using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit
{
    internal class Unit
    {
        private  string _name;
        private int _health;
        private int _maxHealth;
        private int _speed;
        private int _damage;
        private int _defence;

        public Unit(string name, int maxHealth,
            int speed, int damage, int defence)
        {
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _speed = speed;
            _damage = damage;
            _defence = defence;
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
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int MaxHealth
        { get => _maxHealth; }

        public int Health
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

        public void Moving()
        {
            Console.WriteLine($"{_name} is moving with {_speed} speed");
        }

        public virtual void BaseInfo()
                
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Name:{_name} Health: {_health}/{_maxHealth} Speed: {_speed}");
            Console.ResetColor();
        }
        public virtual string HealthAfterDamage()
        {
            return($" {_health}/{_maxHealth}");
            
        }
        public virtual void TakedDamage(int defence)
        {
            defence = Defence;
            int takedDamage = Damage - defence;
            if (takedDamage >= Damage)
            {
                Health += 0;

            }
            Health += takedDamage;
        }
    }
}
