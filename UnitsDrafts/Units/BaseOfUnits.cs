using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class BaseOfUnits
    {
        private int _damage;
        private int _defence;
        private string _name;
        private int _health;
        private int _maxHealth;


        public BaseOfUnits(string name, int health, int maxHealth, int defence, int damage)
        {
            _damage = damage;
            _defence = defence;
            _name = name;
            _health = health;
            _maxHealth = maxHealth;           
        }
        public int Defence
        {
            get { return _defence; }
            set { _defence -= _damage; }
        }
        public int Health
        {
            get
            { return _health; }
            set
            {
                if (value < 0)
                { _health = 0; }
            }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

      

        public virtual void BaseInfo()
        {
            Console.WriteLine($"Name: {Name} | Health: {Health}/{MaxHealth}");
        }
    }
}
