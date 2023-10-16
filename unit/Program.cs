using System;
using unit;

Footman ft1 = new Footman();

Footman ft2 = new Footman("footman2", 55, 12, 10, 7, 6);
Peasant peasant = new Peasant();
Bishop bishop = new Bishop();
Archer archer = new Archer();


Barracs barracs1 = new Barracs();
Meriya meriya = new Meriya();
var fot1 = barracs1.CreateFootman();
var arch1 = barracs1.CreateArchcer();
var bish1 = meriya.CreateBishop();
var peas1 = meriya.CreatePeasant();




Stat.StatInfo();












while (true)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine();
    Console.WriteLine("Выберите действие \n 1.Лечение \n 2.Стрелять \n 3.Footman Rage \n 4.Archer Rage \n 5.Defence check \n 6.Armor check");
    Console.WriteLine();
    Console.ResetColor();
    int choice = int.Parse(Console.ReadLine());
    
    if (choice == 0)
    {
       
        fot1.BaseInfo();
        arch1.BaseInfo();
        bish1.BaseInfo();
        peas1.BaseInfo();
    }
    if (choice == 1)
    {



        Console.WriteLine();
        while (peasant.Health < peasant.MaxHealth && bishop.Mana > 1)
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
        Console.Write("Данные о персонаже: ");
        peasant.BaseInfo();
        Console.WriteLine();


        ft1.BaseInfo();
        ft1.FootmanDamage(peasant);
        Console.WriteLine();
        ft1.BaseInfo();
        ft1.FootmanDamage(peasant);
        Console.WriteLine();
        ft1.BaseInfo();
        ft1.FootmanDamage(peasant);
        Console.WriteLine();
        ft1.BaseInfo();
        ft1.FootmanDamage(peasant);
        Console.WriteLine();
        //ft1.BaseInfo();
        //ft1.FootmanDamage(peasant);
        //Console.WriteLine();



        //if (peasant.Health == 0)
        //{
        //    Console.WriteLine("Вы не можете больше стрелять так как персонаж мертв");
        //}
        Console.WriteLine();
    }
    if (choice == 3)
    {
        ft2.BaseInfo();
        ft1.BaseInfo();
        

        ft2.FootmanDamage(ft1);
        ft1.BaseInfo();
        ft2.FootmanDamage(ft1);
        ft1.BaseInfo();
        ft2.FootmanDamage(ft1);
        ft1.BaseInfo();
        ft2.FootmanDamage(ft1);
        ft1.BaseInfo();




        Console.WriteLine();

        ft1.FootmanDamage(ft2);
        ft2.BaseInfo();
        ft1.BaseInfo();
        ft1.FootmanDamage(ft2);
        ft2.BaseInfo();
        ft1.BaseInfo();
        ft1.FootmanDamage(ft2);
        ft2.BaseInfo();
        ft1.BaseInfo();
        ft1.FootmanDamage(ft2);
        ft2.BaseInfo();
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
        ft1.FootmanDamage(archer);
        archer.BaseInfo();
        ft1.FootmanDamage(archer);
        archer.BaseInfo();
        ft1.FootmanDamage(archer);
        archer.BaseInfo();
        ft1.FootmanDamage(archer);
        archer.BaseInfo();
        archer.ArcherDamage(peasant);
        archer.BaseInfo();
        archer.ArcherDamage(peasant);
        archer.BaseInfo();
        archer.ArcherDamage(peasant);
        archer.BaseInfo();

    }
    if (choice == 5)
    {
        ft1.BaseInfo();
        ft1.TakedDamage(7);
        ft2.BaseInfo();
        ft2.FootmanDamage(ft1);
        ft1.BaseInfo();
        //bishop.BaseInfo();
        //bishop.TakedDamage(4);
        //ft2.BaseInfo();
        //ft2.FootmanDamage(bishop);
        //bishop.BaseInfo();

    }
    if (choice ==6)
    {   
        ft1.BaseInfo();
        archer.BaseInfo();
        archer.ArcherDamage(ft1);
        
        archer.BaseInfo();
    }
}










