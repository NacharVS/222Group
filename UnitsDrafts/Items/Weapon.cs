using System.ComponentModel.DataAnnotations;

namespace UnitsDrafts.Items
{
    internal class Weapon
    {
        public Weapon(string name, int minDamage, int maxDamage, int attackSpeed, int accuracy, int durability, bool Bleed, int stunchance)
        {
            WeaponName = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
            Accuracy = accuracy;
            Durability = durability;
            Bleed = Bleed;
            Stunchance = stunchance;
        }
        public string WeaponName { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int AttackSpeed { get; set; }
        public int Accuracy { get; set; }
        public virtual int Durability
        {

            get { return Durability; }
            set
            {
                if (value < 0)
                {
                    Durability = 0;
                    WeaponAlive = false;
                }
                else
                    Durability = value;
            }
        }
        public bool Bleed { get; set; } = false;
        public int Stunchance { get; set; }
        public bool WeaponAlive { get; set; }
        public virtual int Hit()
        {
            if (Durability != 0)
            {
                var x = new Random().Next(1, 101);
                if (x <= Accuracy)
                {
                    return new Random().Next(MinDamage, MaxDamage + 1);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Оружие сломано");
                return 0;
            }
        }
    }
}
