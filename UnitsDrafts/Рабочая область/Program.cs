using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{ 
    class Program
    {
        static void Main(string[] args)
        {

            MainBuilding mainBuilding = new MainBuilding(); // Главное здание при запуске

            mainBuilding.CreatePeasant();  // Метод для создания строителя
            MainBuilding.peasantList[0].BuildArcheryRange(); // Используем конкретного строителя через лист и строим стрельбище(база лучников)
            
            Peasant.ArcheryRanges[0].CreateArcher(); // Используем конкретное стрельбище и создаем лучника (сразу помещаем в лист)
            ShowCount.ShowQuantity(); // Вывод счетчика
        }
    }
}
