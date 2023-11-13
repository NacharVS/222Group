namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private int _mana;

        public Bishop() : base("Bishop", 40, 7)
        {
        }

        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }



        public void Heals(Unit unit)
        {
            if (unit.MaxHealth > 0)
             {   while (MaxHealth < 100);
            
                unit.Health += 3;
                _mana -= 2;
                while (MaxHealth == 100)
                {
                    Console.WriteLine("Your Unit was healed with help Bishop");
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
            

              Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");


        }
    }
}
