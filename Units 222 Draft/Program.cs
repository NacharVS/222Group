using UnitsDrafts;
using Units_222_Draft.items;
using Units_222_Draft.units;
using Units_222_Draft.Stats;

Console.WriteLine("пососал");
var th = new Townhall();
var br = new Barracs();
var bh = th.SpawnBishop();
var ft = br.SpawnFootman();
var ft1 = br.SpawnFootman();
var ps = th.SpawnPeasant();
Fight.Duel(ft, ft1);
