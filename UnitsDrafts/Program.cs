using TestLibrary;




string[] list = { "Bob", "Sam", "Jeff", "Rob" };
Console.WriteLine(GetNameAge().Item2);
//peasant.HealthDecreasedEvent += MethodVar1;
//peasant.HealthIncreasedEvent += MethodVar2;
//
Person person = new Person();

Person.ForeachTipo(list.GetEnumerator());

foreach (var item in person)
{
    Console.WriteLine(item);
}





static (int, string) GetNameAge()
{
    // many of cooooooooooooooooooooooooooode!
    int a = 10;
    string b = "Dima";
    return (a, b);
    
}

//Console.WriteLine(a.Item1.GetType().ToString());
//Console.WriteLine(a.Item2.GetType().ToString());
//Console.WriteLine(a.Item3.GetType().ToString());



enum WeaponDamage
{
    Axe = 50,
    Bow = 40,
    Sword = 30,
    Gun = 20
}


//peasant.action = () => Console.WriteLine("Action delegate invoked");

//Bishop bish = new Bishop("qq", 40, 2, 4, 5);

//footman.inflictDamage = (Unit unit, int damage) =>
//{
//    unit.Health -= damage;
//    unit.Health += 2;
//    unit.Health += 4;
//    unit.Health += 6;

//};

//footman.inflictDamage(peasant, 15);


//static void MethodVar1(int currentHealth, int diff)
//{
//    Console.WriteLine($"Unit took {diff} of damage. Health: {currentHealth}");
//}

//static void MethodVar2(int currentHealth, int diff)
//{
//    Console.WriteLine($"Unit took {diff} of heal. Health: {currentHealth}");
//}


























