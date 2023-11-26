
namespace UnitsDrafts.Items
{
    internal class Scepter : Weapon
    {
        public Scepter(string name, int minDamage, int maxDamage, int attackspeed, int accuracy, int durability) : base(name, minDamage, maxDamage, attackspeed, accuracy, durability)
        {
        }
        public Scepter() : base("Scepter", 1, 1, 1, 1, 200)
        {
        }
        public override int Hit(Unit unit)
        {
            {
                if (WeaponAlive)
                {
                    Durability-= 50;
                    var x = new Random().Next(1, 100);
                    if (x <= Accuracy)
                    {
                        int Damage = new Random().Next(MinDamage, MaxDamage);
                        x = new Random().Next(1, 100);
                        if (x <= 20)
                        {
                            unit.Stunned = true;
                        }
                        return Damage;
                    }
                    else
                    {
                        Console.WriteLine("Не попал");
                        return 0;
                    }
                }
                else
                {
                    Console.WriteLine("Оружие сломалось");
                    return 0;
                }
            }
        }
    }
}