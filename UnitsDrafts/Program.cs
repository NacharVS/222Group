using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using UnitsDrafts.BuilsingsAll;
using UnitsDrafts.Processes;
using UnitsDrafts.UnitsAll;
using static System.Net.WebRequestMethods;


namespace UnitsDrafts
{
    class Program
    {
        private static Barracs br1 = new Barracs();
        private static TownHall th1 = new TownHall();
        private static MaternityHospital mh1 = new MaternityHospital();

        static void Main(string[] args)
        {

            var ft1 = br1.CreateFootman();
            var ft2 = br1.CreateFootman();
            var bs1 = th1.CreateBishop();
            var ps1 = th1.CreatePeasant();
            ft1.Name = "Первый футман";
            ft2.Name = "Второй футман";

            var battleft1 = br1.CreateFootman();
            var battleft2 = br1.CreateFootman();

            //List<string> myList = new List<string>();

            Menu(ft1, ft2, bs1, ps1, battleft1, battleft2);

        }


        public static void ShowInfo(Footman ft1, Footman ft2, Bishop bs1, Peasant ps1, Footman battleft1, Footman battleft2)
        {
            /*UNIT INFO*/
            Console.WriteLine("Информация о всех юнитах:");
            Console.WriteLine("------------------------------------------------");
            ft1.BaseInfo();
            ft2.BaseInfo();
            bs1.BaseInfo();
            ps1.BaseInfo();
            Console.WriteLine("");
            Console.WriteLine("1.Изменить имя юнита\n2.Вернуться в меню");
            int change_back = Convert.ToInt32(Console.ReadLine());
            if (change_back == 1)
            {
                Console.Clear();
                Console.WriteLine($"Имя какого юнита вы хотите изменить?\n1.{ft1.Name}\n2.{ft2.Name}\n3.{bs1.Name}\n4.{ps1.Name}");
                int unit_change = Convert.ToInt32(Console.ReadLine());
                if (unit_change == 1)
                {
                    Console.WriteLine("Какое имя в дадите юниту?");
                    string name_unit_change = Console.ReadLine();
                    ft1.Name = name_unit_change;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Имя изменено");
                    Console.ResetColor();
                    Menu(ft1, ft2, bs1, ps1, battleft1, battleft2);
                }
                else if (unit_change == 2)
                {
                    Console.WriteLine("Какое имя в дадите юниту?");
                    string name_unit_change = Console.ReadLine();
                    ft2.Name = name_unit_change;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Имя изменено");
                    Console.ResetColor();
                    Menu(ft1, ft2, bs1, ps1, battleft1, battleft2);
                }
                else if (unit_change == 3)
                {
                    Console.WriteLine("Какое имя в дадите юниту?");
                    string name_unit_change = Console.ReadLine();
                    bs1.Name = name_unit_change;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Имя изменено");
                    Console.ResetColor();
                    Menu(ft1, ft2, bs1, ps1, battleft1, battleft2);
                }
                else if (unit_change == 4)
                {
                    Console.WriteLine("Какое имя в дадите юниту?");
                    string name_unit_change = Console.ReadLine();
                    ps1.Name = name_unit_change;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Имя изменено");
                    Console.ResetColor();
                    Menu(ft1, ft2, bs1, ps1, battleft1, battleft2);
                }

            }
            else if (change_back == 2)
            {
                Console.Clear();
                Menu(ft1, ft2, bs1, ps1, battleft1, battleft2);
            }
            else
            {
                Console.Clear();
                ShowInfo(ft1, ft2, bs1, ps1, battleft1, battleft2);
            }
        }

        public static void Menu(Footman ft1, Footman ft2, Bishop bs1, Peasant ps1, Footman battleft1, Footman battleft2)
        {
            Console.WriteLine("Какое действие хотите выполнить?");
            Console.WriteLine("");
            Console.WriteLine("1.Показать информацию о юнитах.");
            Console.WriteLine("2.Создать персонажа.");
            Console.WriteLine("3.Удар");
            Console.WriteLine("4.Хил");
            Console.WriteLine("5.Показать количество юнитов.");
            Console.WriteLine("6.Дуэль");
            Console.WriteLine("7.Вышка обстреливает");
            int deistv = Convert.ToInt32(Console.ReadLine());
            if (deistv == 1)
            {
                Console.Clear();
                ShowInfo(ft1, ft2, bs1, ps1, battleft1, battleft2);
                ShowStatisticProcess.StatInfo();
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------");
                Menu(ft1, ft2, bs1, ps1, battleft1, battleft2);
            }
            else if (deistv == 2)
            {
                Console.Clear();
                //List<string> myList = new List<string>();

                //for (int i = 0; i < 10; i++)
                //{
                //    var a = $"ft{i}";
                //    myList.Add(a);
                //}
                //myList.ForEach(Console.WriteLine);

                Console.WriteLine("Вы хотите создать группу юнитов или одного?");

                Console.WriteLine("1.Группу");
                Console.WriteLine("2.Одного");

                string group = Console.ReadLine();

                Console.WriteLine("Группу каких юнитов хотите создать?");

                Console.WriteLine("1.Лучник");
                Console.WriteLine("2.Бишоп");
                Console.WriteLine("3.Пехотинец");
                Console.WriteLine("4.Житель");

                string kovo = Console.ReadLine();

                Console.WriteLine("Сколько юнитов хотите создать?");

                int skoka = Convert.ToInt32(Console.ReadLine());

                var a = "";
                var dictionaryExample = new Dictionary<string, Unit>();

                switch (kovo)
                {
                    case "1":
                        Console.WriteLine("Идёт набор лучников...");
                        a = "ar";
                        for (var i = 1; i <= skoka; i++)
                        {
                            //dictionaryExample[$"{a}" + i] = br1.CreateArcher(); 
                            dictionaryExample.Add("ar" + i, br1.CreateArcher());
                        }

                        //dictionaryExample.TryGetValue("ar1");
                        var bbb = dictionaryExample[$"{a}1"];
                        bbb.InflictDamage(ft1);

                        dictionaryExample.ToList().ForEach(x => Console.WriteLine(x.Key + " : " + x.Value));


                        foreach (var pair in dictionaryExample)
                        {
                            pair.Value.InflictDamage(ft1);
                            ft1.BaseInfo();
                        }


                        //foreach (int item in dictionaryExample)
                        //{
                        //    MyMethod(item);
                        //}





                        //string arch = dictionaryExample[ar1];
                        //var arch = dictionaryExample.GetValueOrDefault("ar1");
                        //Console.WriteLine(arch);

                        //dictionaryExample.GetValueOrDefault("ar1").InflictDamage(ft1);



                        //foreach (KeyValuePair<string, object> pair in dictionaryExample)
                        //{
                        //    Console.WriteLine("Key = {0}, Value = {1}", pair.Key, pair.Value);
                        //}

                        //dictionaryExample.ToList().ForEach(x => Console.WriteLine(x.Key + " : " + x.Value));

                        //dictionaryExample[ar1].CreateArcher();

                        //foreach (KeyValuePair<string, object> entry in dictionaryExample)
                        //{


                        //}


                        break;
                    case "2":
                        Console.WriteLine("Идёт посвящение в маги...");
                        a = "bs";
                        for (var i = 1; i <= 5; i++)
                        {
                            dictionaryExample[$"{a}" + i] = th1.CreateBishop();
                        }
                        dictionaryExample.ToList().ForEach(x => Console.WriteLine(x.Key + " : " + x.Value));
                        break;
                    case "3":
                        Console.WriteLine("Идёт набор пехотинцев...");
                        a = "ft";
                        for (var i = 1; i <= skoka; i++)
                        {
                            //dictionaryExample[$"{a}" + i] = br1.CreateArcher(); 
                            dictionaryExample.Add(a + i, br1.CreateFootman());
                        }

                        //dictionaryExample.TryGetValue("ar1");
                        bbb = dictionaryExample[$"{a}1"];
                        bbb.InflictDamage(ft1);
                        break;
                    case "4":
                        Console.WriteLine("Рожаем жителей...");
                        a = "ps";
                        for (var i = 1; i <= skoka; i++)
                        {
                            //dictionaryExample[$"{a}" + i] = br1.CreateArcher(); 
                            dictionaryExample.Add(a + i, mh1.CreatePeasant());
                        }

                        //dictionaryExample.TryGetValue("ar1");
                        bbb = dictionaryExample[$"{a}1"];
                        bbb.InflictDamage(ft1);
                        break;
                    default:
                        Console.WriteLine("Неизвестное имя");
                        break;
                }





                Menu(ft1, ft2, bs1, ps1, battleft1, battleft2);
            }
            else if (deistv == 3)
            {
                Console.Clear();

                ft1.BaseInfo();
                ft2.InflictDamage(ft1);
                ft1.BaseInfo();
                ft1.BaseInfo();
                ft2.InflictDamage(ft1);
                ft2.InflictDamage(ft1);
                ft2.InflictDamage(ft1);
                ft2.InflictDamage(ft1);
                ft1.BaseInfo();
                ft1.InflictDamage(ps1);


                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------");
                Menu(ft1, ft2, bs1, ps1, battleft1, battleft2);
            }
            else if (deistv == 4)
            {
                Console.Clear();
                ft1.BaseInfo();
                ft2.BaseInfo();
                bs1.HealSomebody(ft2);
                ft1.BaseInfo();
                ft2.BaseInfo();

                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------");
                Menu(ft1, ft2, bs1, ps1, battleft1, battleft2);
            }
            else if (deistv == 5)
            {
                ShowStatisticProcess.StatInfo();
                Menu(ft1, ft2, bs1, ps1, battleft1, battleft2);
            }
            else if (deistv == 6)
            {
                Console.Clear();
                FightingProcess.Fighting(ft1, ft2, bs1, ps1, battleft1, battleft2);
                Menu(ft1, ft2, bs1, ps1, battleft1, battleft2);

            }
            else if (deistv == 7)
            {
                Console.Clear();
                WatchingTower wt1 = new WatchingTower();
                wt1.AddArcher();
                wt1.AddArcher();
                wt1.AddArcher();

                wt1.DealDamage(ft1);
                ft1.BaseInfo();

                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------");
                Menu(ft1, ft2, bs1, ps1, battleft1, battleft2);

                //ft1.BaseInfo();
            }
        }

        //Menu(ft1, ft2, bs1, ps1);

        //static void Creator(int skoka, Dictionary dictionaryExample)
        //{
        //    Console.WriteLine("Идёт набор лучников...");
        //    a = "ar";
        //    for (var i = 1; i <= skoka; i++)
        //    {
        //        //dictionaryExample[$"{a}" + i] = br1.CreateArcher(); 
        //        dictionaryExample.Add("ar" + i, br1.CreateArcher());
        //    }

        //    //dictionaryExample.TryGetValue("ar1");
        //    var bbb = dictionaryExample["ar1"];
        //    bbb.InflictDamage(ft1);
        //}




    }

}
















