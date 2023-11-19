using UnitsDrafts;
using Units_222_Draft.items;
using Units_222_Draft.units;
using Units_222_Draft.Stats;

Console.WriteLine("пососал");
var th = new Townhall();
var br = new Barracs();
var bh = th.SpawnBishop();
var ft = br.SpawnFootman(); ft.Name = "Василиса";
var ft1 = br.SpawnFootman(); ft1.Name = "Марина";
var ft2 = br.SpawnFootman(); ft2.Name = "Савелий";
var ft3 = br.SpawnFootman(); ft3.Name = "Даниил";

List<Unit> Team1 = new List<Unit>() {ft1,ft };
List<Unit> Team2 = new List<Unit>() {ft2,ft3 };
//Fight.Duel(ft, ft1);
Fight.War(Team1, Team2);