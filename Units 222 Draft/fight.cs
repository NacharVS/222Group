using System;
using Units_222_Draft.units;

namespace UnitsDrafts
{
    internal class Fight
    {
        public static void Duel(Unit unit1, Unit unit2)
        {
            if (unit1.Alive &&  unit2.Alive)
            {
                Test.How_to_Duel();
                Console.WriteLine("=================================================");
                Console.WriteLine($"В дуэли участвуют {unit1.Name} и {unit2.Name}");
                Unit[] duel_spisok = new Unit[2] { unit1, unit2 };
                Unit[] duel_spisok2 = new Unit[2] { unit2, unit1 };
                int count = 0;
                Console.WriteLine("=================================================");
                Console.WriteLine("0 - Атаковать");
                Console.WriteLine("1 - Бежать");
                while (true)
                {
                    if (unit1.Alive != false && unit2.Alive != false)
                    {
                        if (unit1.Run_Away_Count < 20 && unit2.Run_Away_Count < 20)
                        {
                            Console.WriteLine($"{count} ход");
                            for (int i = 0; i < 2; i++)
                            {
                                Console.WriteLine($"Ход {duel_spisok[i].Name}");
                                int choice = Convert.ToInt32(Console.ReadLine());
                                switch (choice)
                                {
                                    case 0:
                                        Console.WriteLine("=================================================");
                                        duel_spisok[i].DealDamage(duel_spisok2[i]);
                                        count++;
                                        break;
                                    case 1:
                                        Console.WriteLine("=================================================");
                                        duel_spisok[i].Moving();
                                        count++;
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
                Console.WriteLine($"БОЙ ЗАКОНЧИЛСЯ ЗА {count} ХОДОВ");
            }
            else
            {
                Console.WriteLine("Невозможно начать дуэль с трупом");
            }
        }     
    }
}
