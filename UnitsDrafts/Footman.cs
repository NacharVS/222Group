namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _damage;
        private int _defence;

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
        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }


        public Footman(string name, int maxHealth, int speed, int damage, int defence) 
            : base(name, maxHealth, speed, null)
        {
            _damage = damage;
            _defence = defence;
        }

        public Footman() : base("Footman", 60, 10, null)
        {
            _damage = 13;
            _defence = 2;
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }


        public void InflictDamagefootman(Unit unit)
        {
            unit.Health = unit.Health - _damage;
            Console.WriteLine("Удар");
        }

        

        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Damage: {Damage} Defence: {Defence}");
        }

    }
}
