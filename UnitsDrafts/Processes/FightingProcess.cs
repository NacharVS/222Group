using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsDrafts.UnitsAll;
using static System.Net.WebRequestMethods;

namespace UnitsDrafts.Processes
{
    internal class FightingProcess
    {

        static public Bow boww = new Bow();
        static public Sword swordd = new Sword();
        public static void Fighting(Footman ft1, Footman ft2, Bishop bs1, Peasant ps1, Footman battleft1, Footman battleft2)
        {
            battleft1.Weapon = swordd;
            battleft2.Weapon = swordd;


            
            while (true)
            {
                Console.WriteLine($"Кто будет бить?\n1.{battleft1.Name}\n2.{battleft2.Name}");
                int member = Convert.ToInt32(Console.ReadLine());
                if (member == 1)
                {
                    //ft1.InflictDamage(ft2);
                    battleft1.Weapon.attack(battleft2);
                    Console.WriteLine("Вас атакует мечник!!!");

                    if (battleft2.Health <= 0)
                    {
                        ShowStatisticProcess.KilledQuant--;
                        ShowStatisticProcess.FootmanQuant--;
                        break;
                    }
                }
                else if (member == 2)
                {
                    //ft2.InflictDamage(ft1);
                    battleft2.Weapon.attack(battleft1);
                    if (battleft1.Health <= 0)
                    {
                        ShowStatisticProcess.KilledQuant--;
                        ShowStatisticProcess.FootmanQuant--;
                        break;
                    }
                }
                else
                {
                    Fighting(ft1, ft2, bs1, ps1, battleft1, battleft2);
                }
            }
        }
    }
}

