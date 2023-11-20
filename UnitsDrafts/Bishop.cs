using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private int _mana;
        private int _maxmana;

        public Bishop() : base("Bishop", 40, 7)
        {
            _mana = 20;
            _maxmana = 20;
        }

        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }

        public int MaxMana
        {
            get { return _maxmana; }
            set { _maxmana = value; }
        }

        public void HealSomebody(Unit unit)
        {
            if (unit.Health < unit.MaxHealth)
            {
                if (_mana > 1)
                {
                    _mana -= 2;
                    unit.Health += 5;
                }
            }
            else if (unit.Health > MaxHealth)
            {
                unit.Health = MaxHealth;
            }
            else if (_mana <= 0)
            {
                Console.WriteLine("Маны нет");
                _mana = 0;
            }
            else if (unit.Health < 0)
            {
                Console.WriteLine("ТЫ ЗДОХЪ");

            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Mana: {Mana}/{MaxMana}");
        }

    }
}
