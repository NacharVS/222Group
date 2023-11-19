using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit.Items;

namespace unit
{
    internal class Unit
    {
        private string _name;
        private double _health;
        private int _maxHealth;
        private int _speed;
        private int _damage;
        private int _defence;
        private bool _alive = true;
        private bool _blodloss = false;
        private bool _stun = false;
        private Weapon _weapon;
        public delegate void InflictDamageDelegate(Unit unit);
        public InflictDamageDelegate inflictDamage;
        public Unit(string name, int maxHealth,
            int speed, int defence)
        {
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _speed = speed;
           
            _defence = defence;
            
        }
        public Weapon Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }
        public bool Stun
        {
            get { return _stun; }
            set { _stun = value; }
        }
        public bool Blodloss
        {
            get { return _blodloss; }
            set { _blodloss = value; }
        }
        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
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

        public double Health
        {
            get { return _health; }
            set
            {

                if (value < 0)
                {
                    _health = 0;
                    _alive = false;

                }
                else if (Blodloss)
                {
                    if (_health > 0)
                    {
                        _health -= 1;
                        Console.WriteLine($"bleeding, health{_health}");
                        _health = value;
                    }

                }
                else
                    _health = value;
            }
        }

        public void Moving()
        {
            Console.WriteLine($"{_name} is moving with {_speed} speed");
        }
        public virtual void InflictDamageMethod(Unit unit)
        {
            double Damage = Weapon.Hit(unit);
            if (Alive)
            {
                if (Stun)
                {
                    Console.WriteLine("Юнит оглушен, он не может атаковать");
                }
                else
                {
                    Stun = false;
                    if (unit.Alive)
                    {
                        if (Weapon.Alive)
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Юнит мертв");
                    }
                }
            }
            else
            {
                Console.WriteLine($"{Name} не может атаковать , он мертв");

            }


        }

        public void InflictDamage(Unit unit)
        {
            inflictDamage = InflictDamageMethod;
            inflictDamage(unit);
        }
        public virtual void BaseInfo()

        {
            if (Health <= 0)
            {
                Console.WriteLine($"Name:{_name} Статус: Мертв");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Name:{_name} Health: {_health}/{_maxHealth} Speed: {_speed} Статус: Жив");
                Console.ResetColor();
            }
        }
        public virtual string HealthAfterDamage()
        {
            return ($" {_health}/{_maxHealth}");

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

        public override string ToString()
        {
            return _name;
        }
    }





}

