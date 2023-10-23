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

        public Weapon(int minDamage, int maxDamage, int attackSpeed, int accuracy)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
            Accuracy = accuracy;
        }

        public virtual double Hit()
        {
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
                    return Damage;
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
