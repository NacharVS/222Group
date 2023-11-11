﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit.items;
using UnitsDrafts.unit.items;

namespace UnitsDrafts
{
    internal class Peasant : Unit
    {
        private Weapon _weapon;
        private int _damage;
        private int _defence;
        private double _MaxHealth;
        private double _Health;

        public Peasant(string name, double maxHealth, int speed, int damage, int defence, double health)
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

        public double health
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
            if (unit.Health <= 0) 
            {
                damage = 0;
            }
            Console.WriteLine($"Name:{Name} Health: {unit.Health}/{_MaxHealth} Defence: {_defence}");
        }

        public override void DealDamage(Unit unit)
        {
            int f = Convert.ToInt32(Console.ReadLine());
            if (f == 1)
            {
                _weapon = new Sword();
            }
            if (f == 2)
            {
                _weapon = new Axe();
            }
            if (f == 3)
            {
                _weapon = new Mace();
            }
            if (f == 4)
            {
                _weapon = new Bow();
            }
            double damage = _weapon.Hit(unit);
            if (Stun)
            {
                damage = 0;
            }
            if (Alive)
            {
                if (Stun)
                {
                    Console.WriteLine("Юнит оглушен - он не может атаковать. Damage = 0");
                }
                else
                {
                    if (unit.Alive)
                    {
                        if (_weapon.Alive) 
                        {
                            Console.WriteLine($"{Name} нанес {damage} урона");
                            unit.Health = unit.Health - damage;
                            Console.WriteLine($"У вас {unit.Health} здоровья");
                            if (unit.Health <= 0)
                            {
                                Console.WriteLine($"{unit.Name} убит");
                                unit.Alive = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("оружие сломано");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Труп");
                    }
                }

            }
            else 
            { 
                Console.WriteLine("Юнит не может атаковать - он мертв"); 
            }
        }
    }
}