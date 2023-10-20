using UnitsDrafts;


List<Unit> units = new List<Unit>();
Archer ar1 = new Archer();
Bishop bishop = new Bishop();
Peasant peasant = new Peasant();  

units.Add(new Footman());
units.Add(ar1);
units.Add(bishop);

Console.WriteLine(units.Exists(x => x.MaxHealth == 40 && x.Health == 30));
























