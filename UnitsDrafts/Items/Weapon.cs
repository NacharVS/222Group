using System.ComponentModel.DataAnnotations;

namespace UnitsDrafts.Items
{
    internal class Weapon
    {
        public Weapon(string name, int minDamage, int maxDamage, int attackSpeed, int accuracy, int durability)
        {
            WeaponName = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
            Accuracy = accuracy;
            Durability = durability;
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
        public bool Bleede { get; set; } = false;
        public int Stunchance { get; set; }
        public bool WeaponAlive { get; set; }
        public virtual int Hit(Unit unit)
        {
            if (WeaponAlive == true)
            {
                var x = new Random().Next(1, 101);
                if (x <= Accuracy)
                {
                  int Damage = new Random().Next(MinDamage, MaxDamage + 1);
                  return Damage;
                }
                else
                {
                    Console.WriteLine("Юнит промахнулся");
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
