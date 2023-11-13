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
        
        public static void Arenavoins()
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
            Console.WriteLine("Выберите действие\n 1.Нанести урон\n 2.Сдаться\n 3.Самоубийство(показать возможности)");

        }
        
    }
}
