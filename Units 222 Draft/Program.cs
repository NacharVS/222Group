using UnitsDrafts;
Console.WriteLine("пососал");
var th = new Townhall();
var br = new Barracs();
var bh = th.SpawnBishop();
var arch = br.SpawnArcher();
var ps = th.SpawnPeasant();
fight.Duel(bh, arch);