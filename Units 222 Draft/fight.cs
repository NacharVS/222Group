using System;
using Units_222_Draft.units;
using Units_222_Draft.Stats;

namespace UnitsDrafts
{
    internal class Fight
    {
        public static int fight_count = 0;
        public static void Duel(Unit unit1, Unit unit2)
        {
            if (unit1.Alive &&  unit2.Alive)
            {
                Test.How_to_Duel();
                Console.WriteLine("=================================================");
                Console.WriteLine($"В дуэли участвуют {unit1.Name} и {unit2.Name}");
                List<Unit> duel_spisok = new List<Unit>() { unit1, unit2 };
                List<Unit> duel_spisokRev = new List<Unit>() { unit2, unit1 };
                fight_count = 0;
                Console.WriteLine("=================================================");
                Console.WriteLine("0 - Атаковать");
                Console.WriteLine("1 - Бежать");
                while (true)
                {
                    if (unit1.Alive && unit2.Alive)
                    {
                        if (unit1.Run_Away_Count < 20 && unit2.Run_Away_Count < 20)
                        {
                            Stat.StatusCheck(unit1); 
                            Stat.StatusCheck(unit2);
                            Console.WriteLine($"{fight_count} ход");
                            for (int i = 0; i < 2; i++)
                            {
                                Console.WriteLine($"Ход {duel_spisok[i].Name}");
                                int choice = Convert.ToInt32(Console.ReadLine());
                                switch (choice)
                                {
                                    case 0:
                                        Console.WriteLine("=================================================");
                                        duel_spisok[i].DealDamage(duel_spisokRev[i]);
                                        fight_count++;
                                        break;
                                    case 1:
                                        Console.WriteLine("=================================================");
                                        duel_spisok[i].Moving();
                                        fight_count++;
                                        break;
                                }
                            }
                        }
                        else if (unit1.Run_Away_Count >= 20)
                        {
                            Console.WriteLine("=================================================");
                            Console.WriteLine($"{unit1.Name}сбежал");
                            break;
                        }
                        else if (unit2.Run_Away_Count >= 20)
                        {
                            Console.WriteLine("=================================================");
                            Console.WriteLine($"{unit2.Name} сбежал");
                            break;
                        }
                    }
                    else { break; }
                }
                Console.WriteLine("=================================================");
                Console.WriteLine($"БОЙ ЗАКОНЧИЛСЯ ЗА {fight_count} ХОДОВ");
            }
            else
            {
                Console.WriteLine("Невозможно начать дуэль с трупом");
            }
        }     
    }
}
