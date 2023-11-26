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


            MainBuilding.peasantList[0].BuildFootmansTrainingGroind();
            MainBuilding.peasantList[0].BuildArcheryRange(); // Используем конкретного строителя через лист и строим стрельбище(база лучников) и тренировочный полигон(база воинов)
            
            
            Peasant.ArcheryRanges[0].CreateArcher(); // Используем конкретное стрельбище из листа и создаем лучника (сразу лучника помещаем в отдельный лист лист)
            Peasant.FootmansTrainingGrounds[0].CreateFootman(); // Используем конкретный тренировочный полигон из листа и создаем воина (сразу помещаем воина в отдельный лист лист)
            ShowCount.ShowQuantity(); // Вывод счетчика
        }
    }
}
