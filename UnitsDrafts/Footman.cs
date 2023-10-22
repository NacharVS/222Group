using System.ComponentModel.Design;
using UnitsDrafts;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _defence;

        private int _damage;

        public Footman(string name, int maxHealth, int speed, int damage, int defence, int health) 
            : base(name, maxHealth, speed, defence, damage, health)
        {
            _damage = damage;
            _defence = defence;
        }
        public int Defence 
        {
            get {  return _defence; }
            set { _defence = value; }
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public Footman() : base("Footman", 30, 10, 10, 30, 3)
        {
            _damage = 15;
            _defence = 10;
        }

        public void InflictDamage(Unit unit)
        {
            if (Health < 24)
            {
                _damage = _damage + _damage / 2;
                unit.Health = unit.Health - _damage;
                Console.WriteLine($"Вашему герою нанесено {_damage} урона");
            }
            else if (Health >= 24)
            {
                unit.Health -= _damage;
                Console.WriteLine($"Вашему герою нанесено {_damage} урона");
            }

            if (_defence > _damage)
            {
                _defence = _damage;
                unit.Health = unit.Health - (_damage - _defence);
            }
            else
            {
                unit.Health = unit.Health - (_damage - _defence);
            }
        }
    }
}
