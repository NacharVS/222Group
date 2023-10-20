namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private int _defence;

        private int _mana;

        public Bishop(string name, int maxHealth, int speed, int mana, int defence, int damage, int health)
            : base(name, maxHealth, speed, defence, damage, health)
        {
            _defence = defence;
            _mana = mana;
        }

        public Bishop() : base("Bishop", 60, 10, 20, 10, 3)
        {
            
            _mana = 150;
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