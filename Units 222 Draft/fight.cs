using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitsDrafts
{
    internal class fight
    {
        public static void duel(Unit unit1, Unit unit2)
        {
            Unit[] duel_spisok = new Unit[2] {unit1,unit2};
            Unit[] duel_spisok2 = new Unit[2] { unit2, unit1 };
            int count = 0;
            while (true)
            {
                if (unit1.Alive != false && unit2.Alive != false)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        duel_spisok[i].DealDamage(duel_spisok2[i]);
                        count++;
                        Console.WriteLine($"бой закончился за {count} ходов");
                    }
                }
                else { break; }
            }
        }
    }
}
