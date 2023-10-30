using UnitsDrafts;

Footman ft1 = new Footman();
Footman ft12 = new Footman();
Peasant peasant = new Peasant();    
Archer archer = new Archer();
Bishop bs1 = new Bishop(20, 20);


//ft1.InflictDamage(archer);
//archer.BaseInfo();
//ft1.InflictDamage(archer);
//archer.BaseInfo();
//ft1.InflictDamage(archer); 
//archer.BaseInfo();
//ft1.InflictDamage(archer);
archer.BaseInfo();
archer.BaseInfo();
Factory fac = new Factory();
var WT = fac.CreateWTower();
var WT1 = fac.CreateWTower();
WT.Upgradee();
WT.Upgradee();
WT.Upgradee();
WT.Upgradee();
WT.Upgradee();
WT.Upgradee();
WT.Upgradee();
WT.Upgradee();
WT.Upgradee();
WT.Upgradee();
WT.Upgradee();
WT.Upgradee();
WT1.Upgradee();
WT1.Upgradee();
WT1.Upgradee();
WT1.Upgradee();
WT.BaseInfo();
WT.TowerInfo();
WT1.TowerInfo();

TownHall th = new TownHall();
//var footman1 = CreateWarrior();
//var archer1 = CreateArch();
var bishop1 = th.CreateBis();
var peas = th.CreatePeas();
Statistics.ShowStatistics();



//bs1.HealSomebody(peasant);
//peasant.BaseInfo();

//ft1.InflictDamage(ft12);
//ft12.BaseInfo();












