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
    else
    {
        break;
    }
}
