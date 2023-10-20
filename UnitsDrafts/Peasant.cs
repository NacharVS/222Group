namespace UnitsDrafts
{
    internal class Peasant : Unit
    {
        private int _damage;
        private int _defence;
        private int _MaxHealth;
        private int _Health;

        public Peasant(string name, int maxHealth, int speed, int damage, int defence, int health)
            : base(name, maxHealth, speed, defence, damage, health)
        {
            _Health = Health;
            _MaxHealth = maxHealth;
            _damage = damage;
            _defence = defence;
        }
        public Peasant() : base("Peasant", 30, 30, 20, 15, 3)
        {
            _defence = 10;
            _damage = 15;
            _MaxHealth = 30;
            _Health = 30;
        }

        public int defence
        {
            get { return _defence; }
            set { _defence = value; }
        }

        public int damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public int health
        {
            get { return _Health; }
            set { _Health = value; }
        }

        public override void BaseInfo()
        {
            if (_defence > _damage)
            {
                _defence = _damage;
                _Health = _Health - (_damage - _defence);
            }
            else
            {
                _Health = _Health - (_damage - _defence);
            }
            if (_Health <= 0)
            {
                _Health = 0;
                Console.WriteLine("Peasant died");
            }
            Console.WriteLine($"Name:{Name} Health: {_Health}/{_MaxHealth} Defence: {_defence}");
        }
    }
}

