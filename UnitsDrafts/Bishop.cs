namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private int _mana;

        public Bishop() : base("Bishop", 40, 7)
        {
        }

        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }

        public void HealSomebody(Unit unit)
        {
            if (unit.Health > 0)
            {
                _mana -= 2;
                unit.Health++;
            }
            else if (unit.Health > MaxHealth)
            {
                unit.Health = MaxHealth;
            }
            else if (_mana <= 0)
            {
                Console.WriteLine("Маны нет");
            }
            else if (unit.Health < 0)
            {
                Console.WriteLine("ТЫ ЗДОХЪ");
            }
        }



    }
}
