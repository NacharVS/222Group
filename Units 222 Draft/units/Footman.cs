using System;
using Units_222_Draft.items;
using UnitsDrafts;

namespace Units_222_Draft.units
{
    internal class Footman : Unit
    {
        public Footman(string name, int maxHealth, int defense, int damage, int speed)
            : base(name, maxHealth, defense, damage, speed)
        {
        }
        public Footman() : base("Footman", 60, 10, 0, 5)
        {
            Weapon = new Sword();
        }
        
        public override void DealDamage(Unit unit)
        {
            if (Alive)
            {
                if (unit.Alive)
                {
                    if (Weapon.Alive)
                    {
                        double Damage = Weapon.Hit();
                        double Rage_damage = 0;
                        if (Health < MaxHealth * 0.4)
                        {
                            Console.WriteLine("===========================================");
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
                            Console.WriteLine("Юнит убит");
                            ++Stat.CorpseQuantity;
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
                    Console.WriteLine("Нахуй ты труп атакуешь?");
                }
            }
            else
            {
                Console.WriteLine("Юнит мертв - он не может атаковать");
            }

        }
    }
}
