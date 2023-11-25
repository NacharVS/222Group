using System;
using UnitsDrafts.Processes;
using UnitsDrafts.UnitsAll;

namespace UnitsDrafts.BuilsingsAll
{
    internal class WatchingTower
    {
        public int Capasity
        {
            get { return 3; }
            set { Capasity = value; }
        }
        public int Damage
        {
            get { return 7 * Garnizon.Count; }
        }
        public List<Unit> Garnizon = new List<Unit>();

        public void AddArcher()
        {
            if (Garnizon.Count < Capasity)
            {
                Garnizon.Add(new Archer());
            }
            else
            {
                Console.WriteLine("Гарнизон забит");
            }
        }
        public void DealDamage(Unit unit)
        {
            // Console.WriteLine(Garnizon.Count);
            if (Garnizon.Count > 0)
            {
                // Console.WriteLine(unit.Health);
                if (unit.Health > 0)
                {
                    int def_damage = Damage - unit.Defence;
                    //Console.WriteLine(def_damage);
                    //Console.WriteLine(Damage);
                    if (def_damage < 0)
                    {
                        def_damage = 0;
                    }
                    //Console.WriteLine($"Гарнизон нанес {def_damage} урона");
                    unit.Health = unit.Health - def_damage;
                    if (unit.Health <= 0)
                    {
                        Console.WriteLine("Юнит убит");
                        ++ShowStatisticProcess.KilledQuant;
                        unit.Health = 0;
                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Юниту {unit.Name} нанесено {def_damage} урона");
                        Console.WriteLine($"У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.WriteLine("Объект мёртв");
                }
            }
            else
            {
                Console.WriteLine("Гарнизон пуст - стрелять некому");
            }
        }

    }
}