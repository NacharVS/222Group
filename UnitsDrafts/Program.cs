using UnitsDrafts;
Footman ft1 = new Footman();
Archer ar1 = new Archer();
Bishop bp1 = new Bishop();
TownHall th1 = new TownHall();
Statistics st1 = new Statistics();

ft1.InflictDamage(ar1);
ft1.InflictDamage(ar1);
bp1.Heals(ar1);
ar1.ShowInfo();

th1.CreateBishop();
Statistics.ShowStatistics();





















