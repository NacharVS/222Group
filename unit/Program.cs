using System;
using unit;
using unit.buildings;
using unit.Items;
using unit.units;

//Footman ft1 = new Footman();

//Footman ft2 = new Footman("footman2", 55, 12, 10, 7, 6);
//Peasant peasant = new Peasant();
//Bishop bishop = new Bishop();
//Archer archer = new Archer();

Barracs barracs1 = new Barracs();
Meriya meriya = new Meriya();
var ft1 = barracs1.CreateFootman();
var ft2 = barracs1.CreateFootman();
var archer = barracs1.CreateArchcer();
var bishop = meriya.CreateBishop();
var peasant = meriya.CreatePeasant();
WatchingTowers wt = new WatchingTowers();

Sword sword = new Sword();



//sword.ShowWeaponInfo();
//sword.LevelUp();
//sword.ShowWeaponInfo();
//Console.WriteLine();

//ft1.BaseInfo();
//while (ft1.Health>0)
//{
//    wt.TowerDamage(ft1);
//    ft1.BaseInfo();
//}


//ft1.InflictDamage(ft2);
//Console.WriteLine($"{ft1.Weapon.WeaponName}");
//ft1.InflictDamage(ft2);

//ft1.InflictDamage(ft2);
//ft1.InflictDamage(ft2);
while (true)
{
    Stat.StatInfo();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine();
    Console.WriteLine("Выберите действие 0.Статистика" +
        " \n 1.Лечение" +
        " \n 2.Стрелять" +
        " \n 3.Footman Rage" +
        " \n 4.Archer Rage" +
        " \n 5.Defence check" +
        " \n 6.Armor check" +
        " \n 7.Дуэль " +
        "\n 8.Archer Dead check " +
        "\n 9.Footman Dead check " +
        "\n 10.ArcherTower" +
        "\n 11.Gnome Sort");
    Console.WriteLine();
    Console.ResetColor();
    int choice = int.Parse(Console.ReadLine());

    if (choice == 0)
    {
        Stat.StatInfo();

    }
    if (choice == 1)
    {


        //ft1.InflictDamage(bishop);
        bishop.BaseInfo();
        Console.WriteLine();
        while (peasant.Health < peasant.MaxHealth && bishop.Mana > 1 && bishop.Alive)
        {
            //Console.WriteLine("Было");
            //bishop.ManaInfo();
            //peasant.BaseInfo();
            //bishop.HealSomebody(peasant);
            //Console.WriteLine("стало");
            //bishop.ManaInfo();
            //peasant.BaseInfo();
            bishop.HealSomebody(peasant);
            bishop.ManaInfo();
            peasant.BaseInfo();

            if (bishop.Mana <= 1)
            {
                Console.WriteLine("недостаточно маны");
            }
            if (peasant.Health == peasant.MaxHealth)
            {
                Console.WriteLine("У персонажа максимальное здоровье");
            }


        }
    }
    if (choice == 2)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("1.Убить полностью \n2.Подамажить");
        Console.WriteLine();
        Console.ResetColor();
        int damagechoice = int.Parse(Console.ReadLine());
        Console.Write("Данные о персонаже: ");
        peasant.BaseInfo();
        Console.WriteLine();
        if (damagechoice == 1)
        {
            while (peasant.Health > 0)
            {
                ft1.BaseInfo();
                ft1.InflictDamage(peasant);
                Console.WriteLine();
            }


            if (damagechoice == 2)
            {
                Console.Write("Данные о персонаже: ");
                peasant.BaseInfo();
                Console.WriteLine();


                ft1.BaseInfo();
                ft1.InflictDamage(peasant);
                Console.WriteLine();
                ft1.BaseInfo();
                ft1.InflictDamage(peasant);
                Console.WriteLine();
                ft1.BaseInfo();
                ft1.InflictDamage(peasant);
                Console.WriteLine();
                ft1.BaseInfo();
                ft1.InflictDamage(peasant);
                Console.WriteLine();
                //ft1.BaseInfo();
                //ft1.FootmanDamage(peasant);
                //Console.WriteLine();
            }

            //if (peasant.Health == 0)
            //{
            //    Console.WriteLine("Вы не можете больше стрелять так как персонаж мертв");
            //}
            Console.WriteLine();
    }   }
        if (choice == 3)
        {
            ft2.BaseInfo();
            ft1.BaseInfo();


            ft2.InflictDamage(ft1);
            ft1.BaseInfo();
            ft2.InflictDamage(ft1);
            ft1.BaseInfo();
            ft2.InflictDamage(ft1);
            ft1.BaseInfo();
            ft2.InflictDamage(ft1);
            ft1.BaseInfo();




            Console.WriteLine();

            ft1.InflictDamage(ft2);

            ft1.BaseInfo();
            ft1.InflictDamage(ft2);

            ft1.BaseInfo();
            ft1.InflictDamage(ft2);

            ft1.BaseInfo();
            ft1.InflictDamage(ft2);

            ft1.BaseInfo();

            //ft1.FootmanDamage(archer);
            //archer.BaseInfo();
            //ft1.FootmanDamage(archer);
            //archer.BaseInfo();
            //ft1.FootmanDamage(archer);
            //archer.BaseInfo();


        }
        if (choice == 4)
        {
            ft1.InflictDamage(archer);
            archer.BaseInfo();
            ft1.InflictDamage(archer);
            archer.BaseInfo();
            ft1.InflictDamage(archer);
            archer.BaseInfo();
            ft1.InflictDamage(archer);
            archer.BaseInfo();
            archer.InflictDamage(peasant);
            archer.BaseInfo();
            archer.InflictDamage(peasant);
            archer.BaseInfo();
            archer.InflictDamage(peasant);
            archer.BaseInfo();

        }
        if (choice == 5)
        {
            ft1.BaseInfo();
            ft1.TakedDamage(7);
            ft2.BaseInfo();
            ft2.InflictDamage(ft1);
            ft1.BaseInfo();
            //bishop.BaseInfo();
            //bishop.TakedDamage(4);
            //ft2.BaseInfo();
            //ft2.FootmanDamage(bishop);
            //bishop.BaseInfo();

        }
        if (choice == 6)
        {

            ft1.BaseInfo();
            archer.BaseInfo();
            ft1.ArmorTake(ft1.Armor);
            archer.InflictDamage(ft1);

            ft1.BaseInfo();

        }
        if (choice == 7)
        {

            Footman footman1 = new Footman("Misha", new Random().Next(70, 85), 10, 0, 6, 5);
            Footman footman2 = new Footman("Elvin", new Random().Next(70, 85), 10, 0, 6, 5);

            Duel.Fighting(footman1, footman2);
        }
        if (choice == 8)
        {
            archer.BaseInfo();
            ft1.InflictDamage(archer);
            ft1.InflictDamage(archer);
            ft1.InflictDamage(archer);
            ft1.InflictDamage(archer);
            ft1.InflictDamage(archer);
            archer.BaseInfo();
            archer.InflictDamage(ft1);
            archer.BaseInfo();
        }
        if (choice == 9)
        {
            ft1.BaseInfo();
            archer.InflictDamage(ft1);
            archer.InflictDamage(ft1);
            archer.InflictDamage(ft1);
            archer.InflictDamage(ft1);
            archer.InflictDamage(ft1);
            archer.InflictDamage(ft1);
            ft1.BaseInfo();
            ft1.InflictDamage(archer);
        }
        if (choice == 10)
        {

            wt.UnitsCount();
            wt.ShowTowerUnits();
            wt.Upgrade();
            wt.ShowTowerUnits();
            wt.UnitsCount();

        }
        Axe axe = new Axe(); Bow bow = new Bow(); Mace mace = new Mace();
        if (choice == 11)
        {

            var array = new Weapon[4] { sword, axe, bow, mace };
            var ildar = GnomeSort(array);

            foreach (Weapon weapon in ildar)
            {
                Console.WriteLine(weapon.WeaponName + " " + weapon.MinDamage);
            }

            static void Swap(ref Weapon item1, ref Weapon item2)
            {
                var temp = item1;
                item1 = item2;
                item2 = temp;
            }

            //Гномья сортировка
            static Weapon[] GnomeSort(Weapon[] unsortedArray)
            {
                var index = 1;
                var nextIndex = index + 1;

                while (index < unsortedArray.Length)
                {
                    if (unsortedArray[index - 1].MinDamage < unsortedArray[index].MinDamage)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                    else
                    {
                        Swap(ref unsortedArray[index - 1], ref unsortedArray[index]);
                        index--;
                        if (index == 0)
                        {
                            index = nextIndex;
                            nextIndex++;
                        }
                    }
                }

                return unsortedArray;
            }
        }
    
}











