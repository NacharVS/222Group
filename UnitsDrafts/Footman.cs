using System.Diagnostics.Metrics;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        int Count = 0;
        public Footman(string name, int maxHealth, int defense,int damage, int speed) 
            : base(name, maxHealth, defense, damage, speed)
        {
            
        }
        public Footman() : base("Footman", 60, 10, 17, 5)
        {

        }

        public override void DealDamage(Unit unit)
        {
            double Rage_damage = 0;
            if (Health < MaxHealth*0.4 )
            {
                Console.WriteLine();
                Rage_damage += Damage * 0.5;
            }
            double def_damage = Damage + Rage_damage - unit.Defense;
            if (def_damage < 0)
            {
                def_damage = 0;
            }
            Console.WriteLine($"{Name} dealed {def_damage} damage");
            unit.Health = unit.Health - def_damage;
            if (unit.Health <= 0)
            {
                Console.WriteLine("Unit died");
            }
            else
            {
                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
            }
        }
    }
}
