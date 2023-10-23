﻿using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace UnitsDrafts
{

    internal class Archer : Unit
    {               
        private int _speed;
        private int _damage;
        
        public Archer(string name, int maxHealth, int speed, int damage, int defence, int health)
            : base(name, maxHealth, speed, defence, damage, health)
        {
            damage = _damage;
            speed = _speed;
        }
        public Archer() : base("Archer", 40, 11, 11, 20, 3)
        {
            _damage = 10;
            _speed = 11;
        }
        public void ArcherDamage(Unit unit)
        {
            unit.Health = unit.Health - _damage;
            Console.WriteLine($"Вашему герою нанесено {_damage} урона");
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public void DeadDenasty()
        {
            Console.WriteLine("Юнит умер, движение невозможно");
        }
        public override void BaseInfo()
        { 
            if (Health < 16) 
            {
                _speed += 4;
            }
            else if (Health <= 0)
            {
                Health = 0;
            }
            else
            {
                _speed = 11;
            }
            
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Speed: {_speed} ");
        }
    } 
}
