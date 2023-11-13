using UnitsDrafts;

Footman footman = new Footman();
Peasant peasant = new Peasant();
Bishop bish = new Bishop("qq", 40, 2, 4, 5);
footman.inflictDamage = MethodVar1;
footman.inflictDamage += MethodVar2;
footman.inflictDamage += bish.HealSomebody;
footman.InflictDamage(peasant);


static void MethodVar1(Unit unit, int damage)
{
    Console.WriteLine($"{unit.Name} took {damage} and took stun");
}

static void MethodVar2(Unit unit, int damage)
{
    Console.WriteLine($"{unit.Name} took {damage} and his arm broken");
}


























