using UnitsDrafts;
Console.WriteLine("пососал");
var th = new Townhall();
var br = new Barracs();
var bh = th.SpawnBishop();
var arch = br.SpawnArcher();
var ps = th.SpawnPeasant();
//Fight.Duel(bh, arch);
Test.How_to_Duel();