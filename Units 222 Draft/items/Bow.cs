//3.DURABILITY(Custom) New - 100 %, Worn - 70 %, Old - 40 %.Broken - can't do everything
//4.UPGRADE(Custom)
namespace Units_222_Draft.items
{
    internal class Bow : Weapon
    {
        public Bow(int minDamage, int maxDamage, int attackSpeed, int accuracy) : base(minDamage, maxDamage, attackSpeed, accuracy)
        {
        }
        public Bow() : base(1,15,1,55)
        {

        }
        public override double Hit()
        {
            Durability--;
            if (Durability > 0)
            {
                Durability--;
                double CritChance = 20;
                double CritDamage = 3;
                var x = new Random().Next(1, 100);
                if (x <= Accuracy)
                {
                    double Damage = new Random().Next(MinDamage, MaxDamage);
                    x = new Random().Next(1, 100);
                    if (x <= CritChance)
                    {
                        Damage += Damage * CritDamage;
                    }
                    return Damage * Durability_check();
                }
                else
                {
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
