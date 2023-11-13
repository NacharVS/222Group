using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Fight
     
    {
        public Archer adelianzak = new Archer("adelian lox", 40, 11, false);
        public Footman adeliangraves = new Footman("adelian lox", 60, 10, true);
        
        public void Arenavoins()
        {
            Console.WriteLine("Выберите либо Мечник или Лучник");
            string vibor1 = Console.ReadLine();
            if (vibor1 == "Лучник")
            {
                Console.WriteLine($"Ваш раб готов к битве и его имя{adelianzak.Name}");
            }
            if (vibor1 == "Мечник")
            {
                Console.WriteLine($"Ваш раб готов к битве и его имя{adeliangraves.Name}");
            }
            else
            {
                Console.WriteLine("Такого нет");
                return;
            }
            Console.WriteLine("Выберите действие\n 1.Нанести урон\n 2.Сдаться\n 3.Самоубийство(показать возможности)");
            var vibor2 = Convert.ToInt32(Console.ReadLine());
            if (vibor2 == 1)
            {
                
            }


        }
        
    }
}
