using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using UnitsDrafts.Items;

namespace UnitsDrafts
{
    internal class Unit
    {
        public delegate void DealDamageDelegate(Unit unit);
        public DealDamageDelegate dealdamage;
        private string _name;
        public string _classname;
        private double _health;
        private double _defense;
        private double _maxHealth;
        private double _speed;
        private double _damage;
        public bool _alive = true;
        public Weapon _weapon;
        public bool _stunned = false;
        public bool _bleeding = false;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string ClassName
        {
            get { return _classname; }
            set { _classname = value; }
        }
        public virtual double Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public double Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public virtual double Health
        {

            get { return _health; }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                    Alive = false;
                }
                else
                    _health = value;
            }
        }

        public double MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }
        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
        }
        public Weapon Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }
        public bool Stunned
        {
            get { return _stunned; }
            set { _stunned = value; }
        }
        public bool Bleeding
        {
            get { return _bleeding; }
            set { _bleeding = value; }
        }
        public virtual void Moving()
        {
            if (Alive)
            {
                Console.WriteLine($"{Name} is moving with {Speed} speed");
            }
            else
            {
                Console.WriteLine($"{Name} dead");
            }
        }
        public virtual void BaseInfo()
        {
            if (Alive)
            {
                Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Defense: {Defense} Speed {Speed}");
            }
            else
            {
                Console.WriteLine($"{Name} dead");
            }
        }
        public Unit(string name, double maxHealth, double defense, double damage, double speed)
        {
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _defense = defense;
            _damage = damage;
            _speed = speed;
        }
        public void FootmanDealDamage(Unit unit)
        {
            double Damage = Weapon.Hit(unit);
            double Rage_damage = 0;
            if (Health < MaxHealth * 0.4)
            {
                Console.WriteLine();
                Rage_damage += Damage * 0.5;
            }
            double def_damage = Damage + Rage_damage - unit.Defense;
            if (def_damage < 0)
            {
                def_damage = 0;
            }
            Console.WriteLine($"{Name} dealed {def_damage} damage");
            unit.Health = unit.Health - def_damage;
            if (unit.Health <= 0)
            {
                Console.WriteLine("Unit died");
            }
            else
            {
                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
            }
        }
        public void UnitDealDamage(Unit unit)
        {
            double Damage = Weapon.Hit(unit);
            double def_damage = Damage - unit.Defense;
            if (def_damage < 0)
            {
                def_damage = 0;
            }
            Console.WriteLine($"{Name} dealed {def_damage} damage");
            unit.Health = unit.Health - def_damage;
            if (unit.Health <= 0)
            {
                Console.WriteLine("Unit died");
            }
            else
            {
                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
            }
        }

        public virtual void DealDamage(Unit unit)
        {
            if (!Alive)
            {
                Console.WriteLine("Атакованный юнит уже мёртв");
            }
            else
            {
                if (Stunned)
                {
                    Console.WriteLine("Юнит оглушён, он не может атаковать");
                }
                else
                {

                       if (!unit.Alive)
                        {
                                Console.WriteLine("зачем ты атакуешь труп?");
                         }
                            else
                            {
                                if (!Weapon.WeaponAlive)
                                {
                                    Console.WriteLine("Невозможно атаковать сломанным оружием");

                                }
                                else
                                {
                                    if (ClassName == "Footman")
                                    {
                                        dealdamage = FootmanDealDamage;
                                    }
                                    else
                                    {
                                        dealdamage = UnitDealDamage;
                                    }
                                    dealdamage(unit);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
