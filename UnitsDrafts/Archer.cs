namespace UnitsDrafts
{
    internal class Archer : Unit
    {
        public int _damage;
        public Archer(string name, int maxHealth, int speed) : base("Archer", 40, 11, null)
        {
            _damage = 10;
        }
        public override int Health
        {
            get => base.Health;
            set
            {
                base.Health = value;
                if (Health < MaxHealth * 40 / 100)
                {
                    if (_damage < 23)
                    {
                        _damage += 10;
                    }
                }
            }

        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

    }
}
//public override int Health
//{
//    get => base.Health;
//    set
//    {
//        base.Health = value;
//        if (Health < MaxHealth * 40 / 100)
//        {
//            if (_damage < 23)
//            {
//                _damage += 10;
//            }
//        }
//    }

//}
//public void InflictDamagearcher()
//{
//    unit.Health = unit.Health - _damage;
//    Console.WriteLine("Удар");