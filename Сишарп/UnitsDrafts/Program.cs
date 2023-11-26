using UnitsDrafts;

List<Unit> units = new List<Unit>();

Barracs barracs = new Barracs();

Footman footman = new Footman();

Peasant peasant = new Peasant();

footman.InflictDamage(peasant);
peasant.BaseInfo();
footman.InflictDamage(peasant);
peasant.BaseInfo();
footman.InflictDamage(peasant);
peasant.BaseInfo();
footman.InflictDamage(peasant);
peasant.BaseInfo();
footman.InflictDamage(peasant);
peasant.BaseInfo();


Sorting.Sorter();

Console.WriteLine(units.Exists(x => x.MaxHealth == 40 && x.Health == 30));








