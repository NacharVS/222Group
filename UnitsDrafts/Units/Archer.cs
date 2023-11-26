namespace UnitsDrafts
{
    internal class Archer : Unit
    {
        public override int Health
        {
            get => base.Health;
            set => base.Health = value;
        }

        private int _damage;
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public Archer(string name, int maxHealth, int speed, int damage)
             : base(name, maxHealth, speed)
        {
            _damage = damage;
        }
        public Archer() : base("Archer", 40, 11)
        {
            _damage = 15;
        }
        public void InflictDamage(Unit unit)
        {
            if (unit._defence >= 1) //Armour
            {
                unit.Health = unit.Health - _damage / unit._defence;
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
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Damage: {Damage} Speed: {Speed}");
            if (Health < MaxHealth * 4 / 10)
            {
                if (_speed == 15)
                {

                }
                else
                {
                    _speed += 4;
                    Console.WriteLine($"Скорость увеличина, теперь скорость: {Speed}");
                }

            }
            
        }

    }
}
