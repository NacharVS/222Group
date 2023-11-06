using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using unit.Items;
using System.Reflection.Emit;

namespace unit
{
    internal class WatchingTowers
    {
        List<Unit> Garrison = new List<Unit>() { new Archer(), new Archer(), new Archer() };
        static int LevelCount = 0;
        static int TowerAccuracy = 40;
        //static int TowerCrit = 20;


        public void ShowTowerUnits()
        {
            Console.WriteLine();
            Console.WriteLine("Стрелки в башне");
            foreach (var unit in Garrison)
            {
                unit.BaseInfo();
            }

        }
        public void TowerDamage(Unit unit)

        {
            if (unit.Alive)
            {
                if (unit.Health > 0)
                {
                    int x = new Random().Next(1, 101);
                    if (x <= TowerAccuracy)
                    {
                        double Damage = new Random().Next(5, 5 * Garrison.Count);
                        unit.Health -= Damage;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Garrison сделал выстрел, здоровье {unit.Name}: {unit.Health}/{unit.MaxHealth} ");


                        Console.ResetColor();

                    }
                    else
                    {
                        Console.WriteLine("Башня не попала");
                    }
                }

                if (unit.Health <= 0)
                {

                    Stat.KilledQuant++;
                    unit.Alive = false;
                    Console.WriteLine($"Garrison не может больше стрелять так как {unit.Name} мертв");

                }

            }
            else
            {
                Console.WriteLine("Юнит мертв");
                
            }
        }
        public void Upgrade()
        {
            Garrison.Add(new Archer());

            LevelCount++;
            Console.WriteLine($"Уровень башни был повышен, текущий уровень {LevelCount}");
        }
        public void UnitsCount()
        {
            Console.WriteLine($"Уровень башни:{LevelCount}");
        }
    }
}
