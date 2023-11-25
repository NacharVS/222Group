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
        public static void Fighting(Footman ft1, Footman ft2, Bishop bs1, Peasant ps1)
        {
            string AliveUnit1 = "Alive";
            string AliveUnit2 = "Alive";
            while (AliveUnit1 == "Alive" || AliveUnit2 == "Alive")
            {
                Console.WriteLine($"Кто будет бить?\n1.{ft1.Name}\n2.{ft2.Name}");
                int member = Convert.ToInt32(Console.ReadLine());
                if (member == 1)
                {
                    ft1.InflictDamage(ft2);
                    if (ft2.Health <= 0)
                    {
                        ShowStatisticProcess.KilledQuant--;
                        ShowStatisticProcess.FootmanQuant--;
                        break;
                    }
                }
                else if (member == 2)
                {
                    ft2.InflictDamage(ft1);
                    if (ft1.Health <= 0)
                    {
                        ShowStatisticProcess.KilledQuant--;
                        ShowStatisticProcess.FootmanQuant--;
                        break;
                    }
                }
                else
                {
                    Fighting(ft1, ft2, bs1, ps1);
                }
            }
        }
    }
}

