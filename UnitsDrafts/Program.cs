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

Footman footman = new Footman();
footman.ShowInfo();
Footman footman1 = new Footman();
footman1.ShowInfo();
Bishop bishop = new Bishop();
bishop.ShowInfo();
footman.InflictDamagefootman(footman1);
footman1.ShowInfo();
footman.InflictDamagefootman(footman1);
footman1.ShowInfo();
bishop.HealSomebody(footman1);
footman1.ShowInfo();
bishop.ShowInfo(); 













