using System;

namespace UnitsDrafts
{
    internal class WatchingTower
    {
        public int Level = 0;
        public int Capasity
        {
            get { return Capasity+Level; }
            set { Capasity = value; }
        }
        public int Damage
        {
            get { return 7 * Garnizon.Count; }


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
            if (Garnizon.Count > 0)
            {
                if (unit.Alive)
                {
                    double def_damage = Damage - unit.Defense;
                    if (def_damage < 0)
                    {
                        def_damage = 0;
                    }
                    Console.WriteLine($"Гарнизон нанес {def_damage} урона");
                    unit.Health = unit.Health - def_damage;
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
