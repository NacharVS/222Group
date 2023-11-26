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
        private string _name;
        private int _health;
        private int _maxHealth;
        private int _accuracy;

        public BaseOfUnits(string name, int health, int maxHealth, int damage, int accuracy)
        {
            _damage = damage;
            _name = name;
            _health = health;
            _maxHealth = maxHealth;      
            _accuracy = accuracy;
        }

        public int Accuracy
        {
            get { return _accuracy; }
            set { _accuracy = value; }
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
