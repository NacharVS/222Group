using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitsDrafts
{
    internal class Fight
    {
        public static void Duel(Unit unit1, Unit unit2)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine($"В дуэли учавствуют {unit1.Name} и {unit2.Name}");
            Unit[] duel_spisok = new Unit[2] { unit1, unit2};
            Unit[] duel_spisok2 = new Unit[2] { unit2, unit1 };
            int[] run_away = new int[2] { unit1.Run_Away_Count,unit2.Run_Away_Count };
            int count = 0;
            while (true)
            {
                if (unit1.Alive != false && unit2.Alive != false)
                {
                    if (unit1.Run_Away_Count < 20 && unit2.Run_Away_Count<20)
                    {
                        
                        for (int i = 0; i < 2; i++)
                        {
                            int choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 0:
                                    duel_spisok[i].DealDamage(duel_spisok2[i]);
                                    count++;
                                    break;
                                case 1:
                                    duel_spisok[i].Moving();
                                    count++;
                                    break;
                            }

                            
                        }
                    }
                    else if(unit1.Run_Away_Count >= 20)
                    {
                        Console.WriteLine($"{unit1.Name}сбежал");
                        Console.WriteLine("=================================================");
                        break;
                    }
                    else if(unit2.Run_Away_Count >= 20)
                    {
                        Console.WriteLine($"{unit2.Name} сбежал");
                        Console.WriteLine("=================================================");
                        break;
                    }
                    
                }
                else {  break; }
            }
            Console.WriteLine($"БОЙ ЗАКОНЧИЛСЯ ЗА {count} ХОДОВ");
            Console.WriteLine("=================================================");
        }
    }
}
