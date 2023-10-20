﻿using System.Runtime.Serialization.Formatters.Binary;
using UnitsDrafts;

Footman ft1 = new Footman();
Footman ft2 = new Footman();
Peasant peasant = new Peasant();    
Archer archer = new Archer();
Bishop bishop = new Bishop();
Barracs barracs = new Barracs();
Ratusha ratusha = new Ratusha();
WatchingTower watchingTower = new WatchingTower();


Console.WriteLine("Введите номер того, чего хотите сделать");
Console.WriteLine("1.Спид");
Console.WriteLine("2.Дамаге");
Console.WriteLine("3.Броня");
Console.WriteLine("4.Бараки и Ратуша");
Console.WriteLine("5.Хилл");
Console.WriteLine("6.Файт");
Console.WriteLine("7.Башня с тремя лучниками");
int a = int.Parse(Console.ReadLine());
switch (a)
{
    case 1:
        archer.BaseInfo();
        ft1.InflictDamage(archer);
        ft1.InflictDamage(archer);
        archer.BaseInfo();
        break;
    case 2:
        ft1.BaseInfo();
        ft2.InflictDamage(ft1);
        ft1.BaseInfo();
        ft1.InflictDamage(ft2);
        ft2.BaseInfo();
        break;

    case 3:        
        peasant.BaseInfo();
        ft1.InflictDamage(peasant);
        peasant.BaseInfo();
        ft1.InflictDamage(peasant);
        peasant.BaseInfo();
        ft1.InflictDamage(peasant);
        peasant.BaseInfo();
        ft1.InflictDamage(peasant);
        peasant.BaseInfo();
        ft1.InflictDamage(peasant);
        peasant.BaseInfo()       ;
        break;
    case 4:
        
    var foot1 = barracs.CreateFootman();
    var arch1 = barracs.CreateArcher();
    var bish1 = ratusha.CreateBishop();
    var peas1 = ratusha.CreatePeasant();

    foot1.BaseInfo();
    arch1.BaseInfo();
    bish1.BaseInfo();
    peas1.BaseInfo();

    Stat.ShowInfo();     
    break;

    case 5:
        ft2.InflictDamage(ft1);
        ft1.BaseInfo();
        bishop.HealSomebody(ft1);
        ft1.BaseInfo();
        bishop.Ostatoc(); 
        bishop.HealSomebody(ft1);
        ft1.BaseInfo();
        bishop.Ostatoc();
        bishop.HealSomebody(ft1);
        ft1.BaseInfo();
        bishop.Ostatoc();
        break;

    case 6:
        ft1.BaseInfo();
        peasant.PeasantDamage(ft1);
        ft1.BaseInfo();
        ft1.InflictDamage(peasant);
        peasant.BaseInfo();
        peasant.PeasantDamage(ft1);
        ft1.BaseInfo();
        break;

    case 7:
        watchingTower.Garrison();
        break;
}





















