using UnitsDrafts;

User user = new User();
user.Id = 123;
user.Field = "qq";
UserGeneric<string, int> userGeneric = new UserGeneric<string, int>();
userGeneric.Id = "34dft99emgf0g";
userGeneric.Field = 123;
UserGeneric<int, int> userGeneric2 = new UserGeneric<int, int>();
userGeneric2.Id = 2;
userGeneric2.Field = 3;
Sum(5);
Sum("dfdf");
Sum(11.05);
Sum(1.5f);
Sum(user);



static void Sum<T>(T obj1)
{
    Console.WriteLine($"Type: {obj1?.GetType().Name}, Value: {obj1}");
}
//Footman footman = new Footman();
//Peasant peasant = new Peasant();

//peasant.action = () => Console.WriteLine("Action delegate invoked");

//Bishop bish = new Bishop("qq", 40, 2, 4, 5);

//footman.inflictDamage = (Unit unit, int damage) => 
//{
//    unit.Health -= damage;
//    unit.BaseInfo();
//};

//footman.inflictDamage(peasant, 15);


//static void MethodVar1(Unit unit, int damage)
//{
//    Console.WriteLine($"{unit.Name} took {damage} and took stun");
//}

//static void MethodVar2(Unit unit, int damage)
//{
//    Console.WriteLine($"{unit.Name} took {damage} and his arm broken");
//}


























