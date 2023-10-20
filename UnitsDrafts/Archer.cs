using System.Security.Cryptography.X509Certificates;
using UnitsDrafts;

namespace UnitsDrafts
{

    internal class Archer : Unit
    {               
        private int _speed;
        private int _damage;
        private int _Health;
        private int _MaxHealth;
        public Archer(string name, int maxHealth, int speed, int damage, int defence, int health)
            : base(name, maxHealth, speed, defence, damage, health)
        {
            damage = _damage;
           
        }
        public Archer() : base("Archer", 40, 11, 11, 20, 3)
        {
            _damage = 15;
            _speed = 11;
        }
        
        public int Speed
        {
            get { return _speed; }
            set { _speed = 11; }
        }
        public void ArcherInfo(Unit unit)
        {
            unit.Health -= _damage;
            Console.WriteLine($"Name:{Name} Health: {_Health}/{_MaxHealth}");
            {
                if (unit.Health <= 0);
                Console.WriteLine("Ваш юнит мертв");
            }

        }
        public void ArcherDamage(Unit unit)
        {
            unit.Health = unit.Health - _damage;
            Console.WriteLine($"Вашему герою нанесено {_damage} урона");
            if (unit.Health > 2) ;
            {
                Console.WriteLine("Персонаж мертв, бой прекращен");
            }
        }

        public override void BaseInfo()
        { 
            if (Health < 16) 
            {
                _speed += 4;
            }
            else
            {
                _speed = 11;
            }
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Speed: {_speed} ");

    
        }
    } 
}

