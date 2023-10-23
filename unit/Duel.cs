using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit
{
    internal class Duel
    {
        

        internal static void Fighting(Unit unit1, Unit unit2)
        {
            unit1.BaseInfo();
            unit2.BaseInfo();
            while(unit1.Alive || unit2.Alive)
            {
                unit1.InflictDamage(unit2);
                unit2.InflictDamage(unit1);
                if (unit1.Health > 0 && unit2.Health <= 0)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{unit1.Name} победил {unit2.Name}, дуэль закончилась");
                    Console.ResetColor();
                }
            }
            
        }
    }
}
