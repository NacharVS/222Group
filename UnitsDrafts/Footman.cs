namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _damage;

        public Footman(string name, int maxHealth, int speed, int damage) 
            : base(name, maxHealth, speed)
        {
            _damage = damage;
        }

        public Footman() : base("Footman", 60, 10)
        {
            _damage = 13;
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }


        public void InflictDamage(Unit unit)
        {
            unit.Health = unit.Health - _damage;
        }

    }
}
