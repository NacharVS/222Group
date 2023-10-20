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
                List<Unit> list = new List<Unit>();
                list.Add(Barracs.CreateArch());
            }
        }
        
    }
}
