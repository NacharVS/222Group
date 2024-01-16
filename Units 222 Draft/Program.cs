using UnitsDrafts;
using Units_222_Draft.items;
using Units_222_Draft.units;
using Units_222_Draft.Stats;

static void Methodvar1(float currentHealth,float diff)
{
    Console.WriteLine($"{diff} получил дамаг{currentHealth}");
}
static void Methodvar2(float currentHealth, float diff)
{
    Console.WriteLine($"{diff} получил хил{currentHealth}");
}

Console.WriteLine("пососал");
var th = new Townhall();
var br = new Barracs();
var bh = th.SpawnBishop();
var ft = br.SpawnFootman(); ft.Name = "Биба"; ft.Weapon = new Axe();
//даня аксенов сделал кстати
var ft1 = br.SpawnFootman(); ft1.Name = "Боба"; ft1.Weapon = new Axe();
var ft2 = br.SpawnFootman(); ft2.Name = "Пупа"; ft2.Weapon = new Axe();
var ft3 = br.SpawnFootman(); ft3.Name = "Лупа"; ft3.Weapon = new Axe();
Fight.Duel(ft, ft1);
//Fight.War(Team1, Team2);

