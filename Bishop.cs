namespace UnitsDrafts
{
    internal class Bishop : Unit
    {

        private int _mana;

        public Bishop() : base("Gfg", 40, 5, 10,10)
        {
        }

        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }

        public void HealSomebody(Unit peasant)
        {
            peasant.Health = peasant.Health + 2;
            _mana -= 10;
        }
        public void Ostatoc()
        {
            Console.WriteLine($"У вас осталось {_mana} маны");
        }

        public void Vos()
        {
            Console.WriteLine("Здоровье восстановилось!");
        }
    }
}

