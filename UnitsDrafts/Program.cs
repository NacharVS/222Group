using UnitsDrafts;

Footman ft1 = new Footman();
Footman ft12 = new Footman();
Peasant peasant = new Peasant();    
Archer archer = new Archer();
Bishop bs1 = new Bishop(10, 20, 30, 40);


ft1.InflictDamage(archer);
archer.BaseInfo();
ft1.InflictDamage(archer);
archer.BaseInfo();
ft1.InflictDamage(archer);
archer.RageMode(archer);
archer.BaseInfo();

Barracs barracs = new Barracs();
TownHall th = new TownHall();
var footman1 = barracs.CreateWarrior();
footman1.BaseInfo();
var archer1 = barracs.CREAS();
archer1.BaseInfo();
var bishop1 = th.CREEEEAAT();
bishop1.BaseInfo();


//bs1.HealSomebody(peasant);
//peasant.BaseInfo();

//ft1.InflictDamage(ft12);
//ft12.BaseInfo();












