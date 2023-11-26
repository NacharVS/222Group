namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _damage;

        public override int Health
        {
            get => base.Health;
            set => base.Health = value;
        }
        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }


        public Footman(string name, int maxHealth, int speed, int damage, int defence)
            : base(name, maxHealth, speed)
        {
            _damage = damage;
            _defence = defence;
        }

        public Footman() : base("Footman", 60, 10)
        {
            _damage = 13;
            _defence = 3;
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }


        public void InflictDamage(Unit unit)
        {
            if (unit._defence >= 1) //Armour
            {
                unit.Health = unit.Health - _damage / unit._defence;
                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
            }
            else if (Health < MaxHealth * 4 / 10) // Rage
            {
                unit.Health = unit.Health - (_damage + _damage / 2);
                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
            }
            else
            {
                unit.Health = unit.Health - _damage;
                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
            }

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Damage: {Damage} Defence: {Defence}");
        }

    }
}
