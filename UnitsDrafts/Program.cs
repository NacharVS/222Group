using UnitsDrafts;
using UnitsDrafts.items;

// Создаем несколько объектов Weapon
Weapon sword = new Weapon("Sword", 2, 6, 8, 80, 800);
Weapon axe = new Weapon("Axe", 5, 10, 4, 60, 500);
Weapon bow = new Weapon("Bow", 1, 4, 6, 70, 650);

// Помещаем оружие в массив
Weapon[] weapons = new Weapon[] { sword, axe, bow };

// Выводим оружие до сортировки
Console.WriteLine("Оружие до сортировки:");
foreach (Weapon weapon in weapons)
{
    Console.WriteLine($"Название: {weapon.WeapName}, Мин урон: {weapon.MinDamage}");
}

// Сортируем оружие по урону
GnomeSort.GnomeSortWeapons(weapons);

// Выводим оружие после сортировки
Console.WriteLine("\nОружие после сортировки:");
foreach (Weapon weapon in weapons)
{
    Console.WriteLine($"Название: {weapon.WeapName}, Мин урон: {weapon.MinDamage}");
}

Console.WriteLine("");

Footman ft1 = new Footman();
Peasant ps1 = new Peasant();
Archer ac1 = new Archer();
Bishop bp1 = new Bishop();

Barracs bar = new Barracs();
var ftmn1 = bar.CreateFootman();
var ftmn2 = bar.CreateFootman();
var ftmn3 = bar.CreateFootman();

TownHall hall = new TownHall();
var bshp1 = hall.CreateBishop();
var bshp2 = hall.CreateBishop();
var bshp3 = hall.CreateBishop();

Archer[] archers = new Archer[2]
{
   bar.CreateArcher(),
   bar.CreateArcher()
};

Peasant[] peasant = new Peasant[2]
{
   hall.CreatePeasant(),
   hall.CreatePeasant()
};

ft1.dealDamage = MethodVar1;
ft1.dealDamage += MethodVar2;
ft1.dealDamage += bshp1.Healing;
ft1.DealDamage(ac1);


static void MethodVar1(Unit unit, int damage)
{
    Console.WriteLine($"{unit.Name} took {damage} and took stun");
}

static void MethodVar2(Unit unit, int damage)
{
    Console.WriteLine($"{unit.Name} took {damage} and his arm broken");
}

Console.WriteLine("");

Statistics.ShowStatistics();

Console.WriteLine("");

Console.WriteLine("Select an action:");
Console.WriteLine("0 - Archer will damage the footman");
Console.WriteLine("1 - Footman will damage the archer");
Console.WriteLine("2 - Bishop will heal the footman");
Console.WriteLine("3 - Archer information");
Console.WriteLine("4 - Create Footman");
Console.WriteLine("5 - Create Archer");
Console.WriteLine("6 - Create Bishop");
Console.WriteLine("7 - Create Peasant");
Console.WriteLine("8 - Show Statictic");

while (true)
{
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 0)
    {
        ac1.DealDamage(ft1);
    }
    else if (choice == 1)
    {
        ft1.DealDamage(ac1);
    }
    else if (choice == 2)
    {
        bp1.Healing(ft1, 20);
    }
    else if (choice == 3)
    {
        ac1.BaseInfo();
    }
    else if (choice == 4)
    {
        Statistics.FootmanCount++;
    }
    else if (choice == 5)
    {
        Statistics.ArcherCount++;
    }
    else if (choice == 6)
    {
        Statistics.BishopCount++;
    }
    else if (choice == 7)
    {
        Statistics.PeasantCount++;
    }
    else if (choice == 8)
    {
        Statistics.ShowStatistics();
    }
    else
    {
        break;
    }
}

WatchingTower tower = new WatchingTower();

// Добавление 3 лучников
tower.AddArcher(new Archer());
tower.AddArcher(new Archer());
tower.AddArcher(new Archer());

// Улучшение башни
tower.UpgradeTower();

// Добавление 7 лучников после улучшения
tower.AddArcher(new Archer());
tower.AddArcher(new Archer());
tower.AddArcher(new Archer());
tower.AddArcher(new Archer());
tower.AddArcher(new Archer());
tower.AddArcher(new Archer());
tower.AddArcher(new Archer());

Console.WriteLine("Количество лучников в башне: " + tower.ArcherCount);
