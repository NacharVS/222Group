namespace UnitsDrafts
{
    internal class Bishop: Unit

    {
        private int _mana;

        public Bishop(string name, int maxHealth, int speed, int mana)
          : base(name, maxHealth, speed)
        {
            _mana = mana;
        }
        public int mana
        {
            get { return _mana; }
            set { _mana = value; }
        }

        public void HealSomebody(Unit unit)
        {
            while (unit.Health < 30);
            Health ++;
            mana = -2;
            Console.WriteLine(Health);
            

        }

    }
}
