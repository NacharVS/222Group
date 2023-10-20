using UnitsDrafts;

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

Statistics.ShowStatistics();

Console.WriteLine("Select an action:");
Console.WriteLine("0 - Archer will damage the footman");
Console.WriteLine("1 - Footman will damage the archer");
Console.WriteLine("2 - Bishop will heal the footman");
Console.WriteLine("3 - Archer information");
Console.WriteLine("4 - Create Footman");
Console.WriteLine("5 - Create Archer");
Console.WriteLine("6 - Create Archer");
Console.WriteLine("7 - Create Archer");
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
        bp1.Healing(ft1);
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
    else if (choice == 5)
    {
        Statistics.BishopCount++;
    }
    else if (choice == 5)
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
