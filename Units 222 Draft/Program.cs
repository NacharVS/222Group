using UnitsDrafts;
using Units_222_Draft.items;
using Units_222_Draft.units;

//Console.WriteLine("пососал");
var th = new Townhall();
var br = new Barracs();
var bh = th.SpawnBishop();
var ft = br.SpawnFootman();
var arch = br.SpawnArcher();
var ps = th.SpawnPeasant();
ft.DealDamage(arch);
ft.DealDamage(arch);
ft.DealDamage(arch);
ft.DealDamage(arch);
arch.DealDamage(ft);