//3.DURABILITY(Custom) New - 100 %, Worn - 70 %, Old - 40 %.Broken - can't do everything
//4.UPGRADE(Custom)
namespace Units_222_Draft.items
{
    internal class Sword : Weapon
    {
        public Sword(int minDamage, int maxDamage, int attackSpeed, int accuracy) : base(minDamage, maxDamage, attackSpeed, accuracy)
        {
        }

        public Sword() : base (2,7,5,90)
        {

        }
        public override double Hit()
        {
            if (Durability > 0)
            {
                Durability--;
                double CritChance = 20;
                double CritDamage = 0.5;
                var x = new Random().Next(1, 100);
                if (x <= Accuracy)
                {
                    double Damage = new Random().Next(MinDamage, MaxDamage);
                    x = new Random().Next(1, 100);
                    if (x <= CritChance)
                    {
                        Damage += Damage * CritDamage;
                    }
                    return Damage;
                }
            else
            {
                return 0;
            }
            }
            else
            {
                return 0;
            }

        }
    }
}
