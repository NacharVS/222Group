using Units_222_Draft.items;
using Units_222_Draft.Stats;

namespace Units_222_Draft.units
{
    internal class Unit
    {
        private string _name;
        private double _health;
        private double _defense;
        private double _maxHealth;
        private double _speed;
        private bool _alive = true;
        private int run_away_count = 0;//нужно для побега во время файтов 
        private Weapon _weapon;
        public bool _stunned = false;
        public bool _bloodloss = false;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public double Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }
        public virtual double Health
        {

            get { return _health; }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                    Alive = false;
                }
                else
                    _health = value;
            }
        }
        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
        }
        public double MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }
        public int Run_Away_Count
        {
            get; set;
        }
        public Weapon Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }
        public bool Stunned
        {
            get { return _stunned; }
            set {_stunned = value; }
        }
        public bool BloodLoss
        {
            get { return _bloodloss; }
            set { _bloodloss = value; }
        }
        public Unit(string name, double maxHealth, double defense, double speed)
        {
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _defense = defense;
            _speed = speed;
        }

        public virtual void Moving()
        {

            if (Alive)
            {
                if (Stunned)
                {
                    Console.WriteLine("Юнит оглушен он не может двигаться");
                }
                else
                {
                    Run_Away_Count += (int)Speed;
                    Console.WriteLine($"{Name} is moving with {Speed} speed");
                    Console.WriteLine(Run_Away_Count);
                }
                
            }
            else
            {
                Console.WriteLine("Юнит мертв, он не может двигаться");
            }
        }

        public virtual void BaseInfo()
        {
            if (Alive)
            {
                Console.WriteLine($"Name:{Name} \n\rHealth: {Health}/{MaxHealth} \n\rDefense: {Defense} \n\rSpeed: {Speed}\n\rStun: {Stunned} ");
            }
            else
            {
                Console.WriteLine($"Name:{Name} dead Defense: {Defense} Speed {Speed}");
            }

        }

        public virtual void DealDamage(Unit unit)
        {
            double Damage = Weapon.Hit(unit);
            if (Alive)
            {
                if (Stunned)
                {
                    Console.WriteLine("Юнит оглушен - он не может атаковать");
                }
                else
                {
                    if (unit.Alive)
                    {
                        if (Weapon.Alive)
                        {
                            double def_damage = Damage - unit.Defense;
                            if (def_damage < 0)
                            {
                                def_damage = 0;
                            }
                            Console.WriteLine($"{Name} нанес {def_damage} урона");
                            unit.Health = unit.Health - def_damage;
                            if (unit.Health <= 0)
                            {
                                Console.WriteLine("Юнит убит");
                                ++Stat.CorpseQuantity;
                                unit.Alive = false;
                            }
                            else
                            {
                                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Невозможно атаковать сломанным оружием");
                        }
                    }
                    else
                    {
                        Console.WriteLine("зачем ты атакуешь труп?");
                    }
                }
                
            }
            else { Console.WriteLine("Юнит не может атаковать - он мертв"); }
        }

    }
}
