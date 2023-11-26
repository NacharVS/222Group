using System;
using Units_222_Draft.Stats;

namespace Units_222_Draft.units
{
    internal class WatchingTower
    {
        public int Level = 0;
        public int Capasity
        {
            get { return 3 + Level; }
            set { Capasity = value; }
        }
        public List<Unit> Garnizon = new List<Unit>();
        public void ArcherAdd()
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
        public void LevelUp()
        {
            if (Level++ != 7)
            {
                Level++;
            }
            else
            {
                Console.WriteLine("Достигнут Максимальный уровень");
            }
        }
        public void DealDamage(Unit unit)
        {
            float Damage = 7* Garnizon.Count;
            if (Garnizon.Count > 0)
            {
                if (unit.Alive)
                {
                    float def_damage = Damage - unit.Defense;
                    if (def_damage < 0)
                    {
                        def_damage = 0;
                    }
                    Console.WriteLine($"Гарнизон нанес {def_damage} урона");
                    unit.Health  -= def_damage;
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
                    Console.WriteLine("зачем ты атакуешь труп?");
                }
            }
            else
            {
                Console.WriteLine("Гарнизон пуст - стрелять некому");
            }
        }

    }
}
