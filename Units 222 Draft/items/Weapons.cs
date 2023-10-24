//3.DURABILITY(Custom) New - 100 %, Worn - 70 %, Old - 40 %.Broken - can't do everything
//4.UPGRADE(Custom)
namespace Units_222_Draft.items
{
    internal class Weapon
    {
        public int MinDamage;
        public int MaxDamage;
        public int AttackSpeed;
        public int Accuracy;
        public int Durability;
        public bool Alive= true;

        public Weapon(int minDamage, int maxDamage, int attackSpeed, int accuracy)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
            Accuracy = accuracy;
        }
        public double Durability_check()
        {
            if (Durability >= 70)
            {
                return 1;
            }
            else if(Durability >= 40)
            {
                return 0.7;
            }
            else if(Durability>= 0)
            {
                return 0.4;
            }
            else
            {
                return 0;
                Alive = false;
            }
        }
        public virtual double Hit()
        {
            Durability--;
            if (Durability > 0)
            {
                double CritChance = 20;
                double CritDamage = 1;
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
                return 0; }

        }
    }
}
