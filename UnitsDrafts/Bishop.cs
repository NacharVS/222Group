namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private int _mana;
        private int _maxmana;
        public Bishop(int mana, int maxmana) : base("Bishop", 60, 7, false, null)
        {
            _mana = maxmana;
            _maxmana = maxmana;
        }

        public int Mana 
        {
            get { return _mana; }
            set { _mana = value; }
        }

        public int Maxmana
        {
            get { return _maxmana; }
            set { _maxmana = value; }
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
                Console.WriteLine("МАНЫ НЕТУ");
            }
            else if (unit.Health == 0)
            {
                Console.WriteLine("Перс мёртв нельзя хилять");
            }

        }



    }
}
