using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private int _defence;

        private int _mana;

        public Bishop(string name, int maxHealth, int defence, int damage, int speed) : base(name, maxHealth, defence, damage, speed)
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