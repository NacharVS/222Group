using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Peasant : Unit
    {
        private int _damage;
        private int _defence;
        private int _MaxHealth;
        private int _Health;

        public Peasant(string name, int maxHealth, int speed, int damage, int defence, int health)
            : base(name, maxHealth, speed, defence, damage, health)
        {
            _Health = health;
            _MaxHealth = maxHealth;
            _damage = damage;
            _defence = defence;
        }
        public Peasant() : base("Peasant", 30, 30, 20, 15, 3)
        {
            _defence = 10;
            _MaxHealth = 30;
            _Health = 30;
        }
        public int defence
        {
            get { return _defence; }
            set { _defence = value; }
        }

        public int damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public int health
        {
            get { return _Health; }
            set { _Health = value; }
        }

        public void BaseInfo(Unit unit)
        {
            if (_defence > _damage)
            {
                _defence = _damage;
                unit.Health = unit.Health - (_damage - _defence);
            }
            else
            {
                unit.Health = unit.Health - (_damage - _defence);
            }
            if (unit.Health <= 0)
            {
                unit.Health = 0;
                Console.WriteLine("Peasant died");
            }
            Console.WriteLine($"Name:{Name} Health: {unit.Health}/{_MaxHealth} Defence: {_defence}");
        }
    }
}