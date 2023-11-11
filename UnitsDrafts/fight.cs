using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Fight
    {
        public static int fight_count = 0;
        public static void Duel(Unit unit1, Unit unit2)
        {
            if (unit1.Alive && unit2.Alive)
            {

                List<Unit> duel_spisok = new List<Unit>() { unit1, unit2 };
                List<Unit> duel_spisokRev = new List<Unit>() { unit2, unit1 };
                fight_count = 0;
                while (true)
                {
                    if (unit1.Alive && unit2.Alive)
                    {
                        Stat.StatusCheck(unit1);
                        Stat.StatusCheck(unit2);
                        Console.WriteLine($"{fight_count} ход");
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine("====================================");
                            Console.WriteLine($"Ход {duel_spisok[i].Name}");
                            Console.WriteLine("====================================");
                            Console.WriteLine("Выберите оружие:");
                            Console.WriteLine("1.Sword");
                            Console.WriteLine("2.Axe");
                            Console.WriteLine("3.Mace");
                            Console.WriteLine("4.Bow");
                            duel_spisok[i].DealDamage(duel_spisokRev[i]);
                            fight_count++;
                        }
                    }
                    else
                    {
                        break;   
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("бой невозможен");
            }
        }
    }
}
