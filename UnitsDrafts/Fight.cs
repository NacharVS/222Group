using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal static class Fight
     
    {
        
        static void arenavoins()
        {
            string vibor1 = Console.ReadLine();
            Console.WriteLine("Выберите либо Мечник или Лучник");
            if (vibor1 == "Лучник")
            {
                Archer adelianpodsos = new Archer("adelian lox", 40, 11, false);
                Console.WriteLine($"Ваш раб готов к битве и его имя{adelianpodsos.Name}");

            }
            else
            {
                Footman adellol = new Footman("adelian lox", 60, 10, true);
                Console.WriteLine($"Ваш раб готов к битве и его имя{adellol.Name}");
            }

        }
        
    }
}
