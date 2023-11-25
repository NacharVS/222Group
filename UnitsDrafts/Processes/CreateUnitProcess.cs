using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsDrafts.BuilsingsAll;
using UnitsDrafts.UnitsAll;

namespace UnitsDrafts.Processes
{
    internal class CreateUnitProcess
    {
        public static void CreateUnit()
        {
            Barracs br = new Barracs();
            TownHall th = new TownHall();
            Console.WriteLine("Кого вы хотите создать?\n1.Footman\n2.Archer\n3.Bishop\n4.Peasant");
            int deistv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Как вы хотите назвать юнита?");
            string NewUnitName = Console.ReadLine();
            if (deistv == 1)
            {
                //var NewUnitName = br.CreateFootman();
            }

        }
    }
}
