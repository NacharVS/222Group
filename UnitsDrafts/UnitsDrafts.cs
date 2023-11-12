using UnitsDrafts;

Footman ft1 = new Footman();
Peasant ps1 = new Peasant();
Archer ac1 = new Archer();
Bishop bp1 = new Bishop();

Console.WriteLine("Select an action:");
Console.WriteLine("0 - Archer will damage the footman");
Console.WriteLine("1 - Footman will damage the archer");
Console.WriteLine("2 - Bishop will heal the footman");
Console.WriteLine("3 - Archer information");
Console.WriteLine("4 - CreateFootmanCount");
Console.WriteLine("5 - Create Archer");
Console.WriteLine("6 - ShowStatistics");
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
    else if (choice == 6)
    {
        Statistics.ShowStatistics();
    }
    else
    {
        break;
    }
}

Barracs bar = new Barracs();
var ftt1 = bar.CreateFootman();
var ftt2 = bar.CreateFootman();
var ftt3 = bar.CreateFootman();

Archer[] archers = new Archer[2]
{
   bar.CrateArcher(),
   bar.CrateArcher()
};

Statistics.ShowStatistics();
{
    static void Main(string[] args)
    {
        WatchingTower tower = new WatchingTower();

        tower.AddArcher(new Archer());
        tower.AddArcher(new Archer());
        tower.AddArcher(new Archer());
        tower.UpTower();
        tower.AddArcher(new Archer());
        tower.AddArcher(new Archer());
        tower.AddArcher(new Archer());
        tower.AddArcher(new Archer());
        tower.AddArcher(new Archer());
        tower.AddArcher(new Archer());
        tower.AddArcher(new Archer());

        Console.WriteLine("Кол-во лучников в башне: " + tower.ArcherCount);
    }
}













