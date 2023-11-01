using System;
using Units_222_Draft.items;
using Units_222_Draft.Stats;

namespace Units_222_Draft.units
{
    internal class Footman : Unit
    {
        public Footman(string name, int maxHealth, int defense, int damage, int speed)
            : base(name, maxHealth, defense, speed)
        {
        }
        public Footman() : base("Footman", 60, 0, 5)
        {
            Weapon = new Sword();
        }
        
        public override void DealDamage(Unit unit)
        {
            if (Alive)
            {
                if(Stunned)
                {
                    Console.WriteLine("Юнит застанен");
                }
                else
                {
                    if (unit.Alive)
                    {
                        if (Weapon.Alive)
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
            }
            else
            {
                Console.WriteLine("Юнит мертв - он не может атаковать");
            }

        }
    }
}
