namespace UnitsDrafts
{
    internal class Unit
    {
        private readonly string _name;
        private int _health;
        private int _maxHealth;
        private int _speed;
        public Weapon _weapon;
        public Unit(string name, int maxHealth, int speed,Weapon weapon)
        {
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _speed = speed;
            _weapon = weapon;
        }

        public string Name => _name;       
        public int MaxHealth => _maxHealth;

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }


        public virtual int Health
        {
            get { return _health; }
            set 
            { 
                if(value < 0)
                {
                    _health = 0;
                }

                else
                    _health = value; 
            }
        }



        public void Moving()
        {
            Console.WriteLine($"{_name} is moving with {_speed} speed");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name:{_name} Health: {_health}/{_maxHealth}" );
        }

    }
}
