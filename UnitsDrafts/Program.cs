using System.Diagnostics;
using TestLibrary;
//int j = 0;
//var tasks = new List<Task>();
//for (int i = 0; i < 10; i++)
//{
//    tasks.Add(new Task(() =>
//    {
//        Thread.Sleep(Random.Shared.Next(250, 1500));
//        Console.WriteLine($"Root of {j} is {Math.Sqrt(j)}");
//        j++;
//    }));
//}
//foreach (var task in tasks)
//{
//    task.Start();
//}

//Task.WaitAll(tasks.ToArray());
//Console.WriteLine("Finished");
//Console.ReadLine();

T Find<T>(List<T> l, Predicate<T> pred)
{
    for (int i = 0; i < l.Count; i++)
    {
        if (pred(l[i]))
            return l[i];
    }
    return default(T);
}

var x = Enumerable.Range(0, 1000000).Select( i => Random.Shared.Next(0, 1000000));
var xl = x.ToList();
Console.WriteLine(default(int));
Stopwatch sw1 = new Stopwatch();
Stopwatch sw2 = new Stopwatch();
Stopwatch sw3 = new Stopwatch();
Stopwatch sw4 = new Stopwatch();

int iter = 5000;
for (int i = 0; i < iter; i++)
{
    sw1.Start();
    var y = x.FirstOrDefault(i => i == 950000);
    sw1.Stop();
    sw2.Start();
    var z = x.ToList().Find(i => i == 950000);
    sw2.Stop();
    sw3.Start();
    var w = xl.Find(i => i == 950000);
    sw3.Stop();
    sw4.Start();
    var r = Find(xl, i => i == 950000);
    sw4.Stop();
}
sw1.Stop();
sw2.Stop();
Console.WriteLine($"{sw1.Elapsed / (double)iter} {sw2.Elapsed / (double)iter}  {sw3.Elapsed / (double)iter} {sw4.Elapsed / (double)iter}");






//string[] list = { "Bob", "Sam", "Jeff", "Rob" };

//Pistol pp = new Pistol();
//Rifle rr = new Rifle();
//Machinegun mm = new Machinegun();


//UseBurstShooting(mm);

////peasant.HealthDecreasedEvent += MethodVar1;

////peasant.HealthIncreasedEvent += MethodVar2;
////
///







static void UseBurstShooting(IBurstShoot weapon)
{
    weapon.BurtsShoot();
}

static void UseWeapon(IWeapon wepon)
{
    wepon.Shoot();
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


























