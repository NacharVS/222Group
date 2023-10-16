﻿using System.ComponentModel.Design;
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
        public Footman() : base("Footman", 45, 10, 10, 10, 3)
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
            else if(Health >= 24)
            {
                _damage = 15;
                unit.Health -= _damage;
                Console.WriteLine($"Вашему герою нанесено {_damage} урона");
                if (unit.Health < 0) 
                {
                    Console.WriteLine("Юнит убит");
                }
            
            }

        }
        public void Defencee(Unit unit)
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
                Console.WriteLine("Footman died");
            }
        }
        public void TakeDamage(int damage)
        {
            int reducedDamage = damage - Defence;
            if (reducedDamage < 0)
                reducedDamage = 0;

            Health -= reducedDamage;
        }
    }
}


//unit.Health = unit.Health - _damage;
//unit.Defence -= _damage;
//unit.Health = +Defence;