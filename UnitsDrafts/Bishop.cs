namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private int _mana;

        public Bishop() : base("Bishop", 40, 7)
        {
            _mana = 50;
        }

        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }



        public void Heals(Unit unit)
        {
            if (unit.Health > 0 & unit.Health < unit.MaxHealth)
            {
                if (unit.Health < unit.MaxHealth)
                    while (unit.Health < unit.MaxHealth && unit.Health == unit.MaxHealth)
                    {
                        unit.Health += 3;
                        _mana -= 2;
                    }
                else
                {
                    if (unit.Health > unit.MaxHealth)
                        unit.Health = unit.MaxHealth;
                    else
                        Console.WriteLine("Your unit was healed bishop!");
                }
            }
             else if (unit.Health <= 0)
            {
                Console.WriteLine("Your Unit was died, and bishop can't heal");
            }
             else if (_mana <= 2)
            {
                Console.WriteLine("Bishop don't have mana");
            }
            else
            {
                Console.WriteLine("Your unit don't nead heal");
            }
            
             Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");


        }
    }
}
