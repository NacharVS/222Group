namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _defence;

        private Weapon _weapon;

        public Footman() : base("Footman", 60, 5, 2, 6)
        {
            _weapon = new Sword();
        }

        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }


        public void InflictDamage(Unit unit)
        {
            var damage = _weapon.Hit();
            if (damage <= 0)
            {
                Console.WriteLine("Miss");
            }
            else
            {
                unit.Health -= damage;
            }
        }

    }
}
