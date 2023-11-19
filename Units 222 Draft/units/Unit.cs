using Units_222_Draft.items;
using Units_222_Draft.Stats;

namespace Units_222_Draft.units
{
    internal class Unit
    {
        public delegate void MovingDelegate();//
        public MovingDelegate moving;
        public delegate void DealDamageDelegate(Unit unit);//делегат движения
        public DealDamageDelegate dealDamage;

        public void MovingMethod()
        {
            Run_Away_Count += (int)Speed;
            Console.WriteLine($"{Name} двигается со скоростью {Speed}");
            Console.WriteLine(Run_Away_Count);
        }
        // самый обычный дамаг перешедший из прошлого кода
        public void DealDamageMethod(Unit unit)
        {
            float Damage = Weapon.Hit(unit);
            float def_damage = Damage - unit.Defense;
            if (def_damage < 0)
            {
                def_damage = 0;
            }
            Console.WriteLine($"{Name} нанес {def_damage} урона");
            unit.Health = unit.Health - def_damage;
            if (unit.Health <= 0)
            {
                Console.WriteLine($"{unit.Name} убит");
                ++Stat.CorpseQuantity;
                unit.Alive = false;
            }
            else
            {
                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
            }
        }
        //нанесение урона специальное для footman ибо у него rage влияет на урон
        public void FootmanDealDamageMethod(Unit unit)
        {
            float Damage = Weapon.Hit(unit);
            float Rage_damage = 0;
            if (Health < MaxHealth * 0.4)
            {
                Console.WriteLine("===========================================");
                Rage_damage += Damage * 0.5f;
            }
            float def_damage = Damage + Rage_damage - unit.Defense;
            if (def_damage < 0)
            {
                def_damage = 0f;
            }
            Console.WriteLine($"{Name} нанес {def_damage} урона");
            unit.Health -= def_damage;
            if (unit.Health <= 0)
            {
                Console.WriteLine($"{unit.Name} убит");
                ++Stat.CorpseQuantity;
            }
            else
            {
                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
            }
        }

        private string _name;// Имя юнита
        private string _classname;// Имя класса
        private float _health; // Количество очков жизни на данный момент
        private float _defense; // Очки защиты
        private float _maxHealth; // Максимальное количество очков жизни
        private float _speed;// Нужна для побега
        private bool _alive = true; //проверка живой или нет
        private Weapon _weapon;// Оружие юнита
        public bool _stunned = false;// Оглушение
        public bool _bloodloss = false;// Кровотечение
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string ClassName
        {
            get { return _classname; }
            set { _classname = value; }
        }
        public float Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public float Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }
        public virtual float Health
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
        public float MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }
        public int Run_Away_Count
        {
            //необходимо для побега из боя
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
        public Unit(string name, float maxHealth, float defense, float speed)
        {
            _name = name;
            _health = maxHealth;
            _maxHealth = maxHealth;
            _defense = defense;
            _speed = speed;
        }
        //Метод для побега
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
                    moving = MovingMethod;
                    moving();
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
                Console.WriteLine($"Name:{Name} \n\r" +
                    $"Health: {Health}/{MaxHealth} \n\r" +
                    $"Defense: {Defense} \n\r" +
                    $"Speed: {Speed}\n\r" +
                    $"Stun: {Stunned} ");
            }
            else
            {
                Console.WriteLine($"Name:{Name} dead Defense: {Defense} Speed {Speed}");
            }

        }
        // Метод нанесения урона
        public virtual void DealDamage(Unit unit)
        {
            if (!Alive)
            {
                Console.WriteLine("Юнит не может атаковать - он мертв");   
            }
            else {
                if (Stunned)
                {
                    Console.WriteLine("Юнит оглушен - он не может атаковать");
                }
                else
                {
                    if (!unit.Alive)
                    {
                        Console.WriteLine("зачем ты атакуешь труп?");
                    }
                    else
                    {
                        if (!Weapon.Alive)
                        {
                            Console.WriteLine("Невозможно атаковать сломанным оружием");
                            
                        }
                        else
                        {
                            //В зависимости от класса разный способ нанесения урона
                            if (ClassName == "Footman")
                            {
                                dealDamage = FootmanDealDamageMethod;
                            }
                            else
                            {
                                dealDamage = DealDamageMethod;
                            }
                            dealDamage(unit);
                        }
                    }
                }
            }
        }
    }
}
