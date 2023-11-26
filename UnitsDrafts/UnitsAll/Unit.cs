using UnitsDrafts.Processes;
using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts.UnitsAll
{
    internal class Unit
    {
        private string _name;
        private int _health;
        private int _maxHealth;
        private int _speed;
        private int _defence;
        private int _damage;
        public Weapon Weapon;

        public Unit(string name, int maxHealth,
            int speed, int defence, int damage, Weapon weapon)
        {
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _speed = speed;
            _defence = defence;
            _damage = damage;
            Weapon = weapon;
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else
                    _health = value;
            }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public int MaxHealth { get => _maxHealth; }

        public void Moving()
        {
            Console.WriteLine($"{_name} is moving with {_speed} speed");
        }

        public void InflictDamage(Unit unit)
        {

            int reduceDamage;

            switch (Weapon)
            {
                case Sword:
                    Damage = 0;
                    break;
                case Axe:
                    Damage = 0;
                    break;
                case Bow:
                    Damage = 0;
                    break;
                case Morgenstern:
                    Damage = 0;
                    break;
                default:
                    
                    break;
            }


            if (unit.Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                unit.Health = unit.Health - _damage;
                Console.WriteLine("Юнит убит");
                Console.ResetColor();
            }
            else if (Damage <= 0)
            {
                Console.WriteLine(Damage);
                Console.WriteLine("Юнит не бьёт");
            }
            else
            {
                Console.WriteLine(Damage);
                Console.WriteLine("Юнит всё же ударил");
                if (Health < 24)
                {
                    if (unit.Defence <= 0)
                    {
                        Damage = Damage + Damage / 2;
                        Console.ForegroundColor = ConsoleColor.Red;
                        unit.Health = unit.Health - Damage;
                        Console.WriteLine($"Юниту {unit.Name} нанесено {_damage} урона");
                        Console.ResetColor();
                        Damage = 17;
                    }
                    else
                    {
                        Damage = Damage + Damage / 2;
                        reduceDamage = Damage - unit.Defence;
                        if (reduceDamage < 0) reduceDamage = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        unit.Health = unit.Health - reduceDamage;
                        Console.WriteLine($"Юниту {unit.Name} нанесено {reduceDamage} урона");
                        Console.ResetColor();
                        Damage = 17;
                    }

                }
                else
                {
                    if (unit.Defence >= 0)
                    {
                        reduceDamage = Damage - unit.Defence;
                        if (reduceDamage < 0) reduceDamage = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        unit.Health = unit.Health - reduceDamage;
                        Console.WriteLine($"Юниту {unit.Name} нанесено {reduceDamage} урона");
                        Console.ResetColor();
                        if (unit.Health <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Юнит убит");
                            Console.ResetColor();
                            ShowStatisticProcess.KilledQuant++;
                        }
                    }
                    else
                    {
                        reduceDamage = Damage - unit.Defence;
                        if (reduceDamage < 0) reduceDamage = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        unit.Health = unit.Health - reduceDamage;
                        Console.WriteLine($"Юниту {unit.Name} нанесено {reduceDamage} урона");
                        Console.ResetColor();
                        if (unit.Health <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Юнит убит");
                            Console.ResetColor();
                            ShowStatisticProcess.KilledQuant++;
                        }
                    }

                }
            }
        }

        public virtual void BaseInfo()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Name: {_name} |");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Health: {_health}/{_maxHealth}");
            Console.ResetColor();
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Speed: {_speed}");
            Console.ResetColor();
            Console.WriteLine(" | ");
        }

    }
}
