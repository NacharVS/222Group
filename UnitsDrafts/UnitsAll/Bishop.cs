using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts.UnitsAll
{
    internal class Bishop : Unit
    {
        private int _mana;
        private int _speed;

        public Bishop(string name, int maxHealth, int speed, int mana, int defence, int damage)
            : base(name, maxHealth, speed, defence, damage)
        {
            _mana = mana;
        }

        public Bishop() : base("Bishop", 60, 8, 0, 0)
        {
            _mana = 300;
            _speed = 8;
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }

        public void HealSomebody(Unit unit)
        {
            if (unit.Health == 0)
            {
                Console.WriteLine("Вы не можете вылечить Юнита!!");
                Console.WriteLine("Юнит Мертв!");
            }
            else if (unit.Health <= unit.MaxHealth && _mana >= 10)
            {
                if (unit.Health + 1 == unit.MaxHealth)
                {
                    unit.Health = unit.Health + 1;
                    _mana = _mana - 10;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"У юнита осталось {_mana} / 300 маны");
                    Console.ResetColor();
                }
                else if (unit.Health + 2 == unit.MaxHealth)
                {
                    unit.Health = unit.Health + 2;
                    _mana = _mana - 10;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"У юнита осталось {_mana} / 300 маны");
                    Console.ResetColor();
                }
                else if (unit.Health == unit.MaxHealth)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("У юнита максимальное здоровье!");
                    Console.ResetColor();
                }
                else
                {
                    unit.Health = unit.Health + 2;
                    _mana = _mana - 10;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"У юнита осталось {_mana} / 300 маны");
                    Console.ResetColor();
                }
            }
            else
            {
                if (unit.Health >= unit.MaxHealth)
                {
                    unit.Health = unit.MaxHealth;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("У юнита максимальное здоровье!");
                    Console.ResetColor();
                }
                else if (_mana < 10)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("У вас недостаточно маны!");
                    Console.WriteLine($"Маны {_mana} / 300");
                    Console.ResetColor();
                }
            }
        }
        public override void BaseInfo()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Name: {Name} | ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Health: {Health}/{MaxHealth}");
            Console.ResetColor();
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"Mana: {Mana}");
            Console.ResetColor();
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Speed: {Speed}");
            Console.ResetColor();
            Console.WriteLine(" | ");
        }
    }
}