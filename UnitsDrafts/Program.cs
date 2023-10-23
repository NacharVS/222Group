using UnitsDrafts;

List<Unit> units = new List<Unit>();

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


Console.WriteLine(units.Exists(x => x.MaxHealth == 40 && x.Health == 30));








