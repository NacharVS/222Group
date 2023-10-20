using UnitsDrafts;

//Barracs barracs = new Barracs();
//var ft1 = barracs.CreateFootman();
//var ft2 = barracs.CreateFootman();
//var ft3 = barracs.CreateFootman();
//var ft4 = barracs.CreateFootman();
//Archer[] archers = new Archer[3]
//{
//    barracs.CreateArcher(),
//    barracs.CreateArcher(),
//    barracs.CreateArcher()
//};



//Statistics.ShowStatistics();

Archer ar1 = new Archer();
Bishop bp1 = new Bishop();
Footman ft1 = new Footman();

Console.ReadKey();
while (true)
{
    int choice = Convert.ToInt32(Console.ReadKey());

    if (choice == 1)
    bp1.Heals(ft1);
    ft1.ShowInfo();
    else if (choice == 1) ;
    else break;
}














