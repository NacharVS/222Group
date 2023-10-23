using System.ComponentModel.Design;
using unit.items;
using UnitsDrafts;
using UnitsDrafts.unit.items;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _defence;

        private int _damage;

        private Weapon _weapon;
        public Footman(string name, int maxHealth, int speed, int damage, int defence, int health) 
            : base(name, maxHealth, speed, defence, damage, health)
        {
            _weapon = new Sword();
            _defence = defence;
        }
        public int Defence 
        {
            get {  return _defence; }
            set { _defence = value; }
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
                _damage = 15;
            }
            else if (Health >= 24)
            {
                _damage = 15;
                unit.Health -= _damage;
                Console.WriteLine($"Вашему герою нанесено {_damage} урона");
                if (unit.Health < 0)
                {
                    Console.WriteLine("Юнит убит");
                }

            }
            //var damage = _weapon.Hit();
            //if(damage <= 0) 
            //{
            //    Console.WriteLine("miss");
            //}
            //else
            //{
            //    unit.Health -= damage;
            //}
        }
    }
}
