using unit.items;

namespace UnitsDrafts
{
    internal class Sword : Weapon
    {
        private Weapon _weapon;
        double CritDamage = 1.5;
        double CritChance = 20;
        public Sword() : base(2, 7, 8, 100, 12)
        {
        }


        public override double Hit(Unit unit)
        {
            if (Durability > 0)
            {
                Durability -= 2;
                double damage = new Random().Next(MinDamage, MaxDamage);
                int y = new Random().Next(1, 100);
                if (Accuracy >= y)
                {
                    int x = new Random().Next(1, 100);
                    if (x <= CritChance)
                    {
                        damage *= CritChance;
                        Console.WriteLine("Нанесен критический урон");
                        return damage;

                    }
                    return damage * DurabilityCondition();
                }
                else
                {
                    Console.WriteLine("Промах");
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