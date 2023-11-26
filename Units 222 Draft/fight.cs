using System;
using Units_222_Draft.units;
using Units_222_Draft.Stats;
using Units_222_Draft.items;

namespace UnitsDrafts
{
    internal class Fight
    {
        public static int fight_count = 0;
        public static void TeamCheck(List<Unit> Team1, List<Unit> Team2)
        {
            for (int i = 0; i < Team1.Count; i++)
            {
                Stat.StatusCheck(Team1[i]);
                if (!Team1[i].Alive)
                {
                    Team1.Remove(Team1[i]);
                }
            }
            for (int i = 0; i < Team2.Count; i++)
            {
                Stat.StatusCheck(Team2[i]);
                if (!Team2[i].Alive)
                {
                    Team2.Remove(Team2[i]);
                }
            }
        }
        public static void TeamInfo(List<Unit> Team)
        {
            int i = 0;
            foreach (Unit unit in Team) 
            {
                i++;
                Console.WriteLine($"{i}) {unit.Name} Class: {unit.ClassName} HP: {unit.MaxHealth} / {unit.Health} Defense:{unit.Defense}");
            }   
        }
        public static void Duel(Unit unit1, Unit unit2)
        {
            unit1.BloodLossCount = 0;
            unit2.BloodLossCount = 0;
            fight_count = 0;
            if (unit1.Alive && unit2.Alive)
            {
                
                Test.How_to_Duel();
                Console.WriteLine("=================================================");
                Console.WriteLine($"В дуэли участвуют {unit1.Name} и {unit2.Name}");
                List<Unit> duel_spisok = new List<Unit>() { unit1, unit2 };
                // Мне влом делать цикл в цикле потому два списка
                List<Unit> duel_spisokRev = new List<Unit>() { unit2, unit1 };
                
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
                                        break;
                                    case 1:
                                        Console.WriteLine("=================================================");
                                        duel_spisok[i].Moving();
                                        break;
                                    case 2:
                                        break;
                                }
                            }
                            fight_count++;
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
        public static void War(List<Unit> Team1, List<Unit> Team2)
        {
            Fight.fight_count = 0;
            while (true)
            {
                Fight.TeamCheck(Team1, Team2);
                
                if(Team1.Count()==0 || Team2.Count()== 0)
                {
                    Console.WriteLine("==================================");
                    Console.WriteLine();
                    Console.WriteLine("Бой окончен");
                    Console.WriteLine();
                    Console.WriteLine("==================================");
                    break;
                }
                else
                {
                    fight_count++;
                    Console.WriteLine($"Ход : {fight_count}");
                    Console.WriteLine("==================================");
                    Console.WriteLine();
                    Console.WriteLine("Ход команды номер 1");
                    Console.WriteLine();
                    Console.WriteLine("==================================");
                    Console.WriteLine();
                    foreach (Unit unit in Team1)
                    {
                        Console.WriteLine($"Атакует {unit.Name}");
                        Console.WriteLine("Выбери кого атаковать");
                        Fight.TeamInfo(Team2);
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == null)
                        unit.DealDamage(Team2[choice - 1]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("==================================");
                    Console.WriteLine();
                    Console.WriteLine("Ход команды номер 2");
                    Console.WriteLine();
                    Console.WriteLine("==================================");

                    foreach (Unit unit in Team2)
                    {
                        Console.WriteLine($"Атакует {unit.Name}");
                        Console.WriteLine("Выбери кого атаковать");
                        Fight.TeamInfo(Team1);
                        int choice = Convert.ToInt32(Console.ReadLine());
                        unit.DealDamage(Team1[choice - 1]);
                    }
                }
            }
        }
    }
}