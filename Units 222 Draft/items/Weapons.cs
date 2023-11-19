using System.Security.Cryptography.X509Certificates;
using Units_222_Draft.units;
using UnitsDrafts;

namespace Units_222_Draft.items
{
    internal class Weapon
    {
        public int MinDamage;// минимальный урон у оружия
        public int MaxDamage;// максимальный урон у оружия
        public int AttackSpeed;// скорость атаки (не используется но по ТЗ нужно)
        public int Accuracy;// точность
        public int Durability = 100; //прочность
        public bool Alive = true;//не сломано ли оружие
        public string Name;//название оружия
        public float Level = 0;//уровень

        public Weapon(int minDamage, int maxDamage, int attackSpeed, int accuracy)
        {
            MinDamage = minDamage;//min|max damage на один меньше|больше чтобы был достигнут правильный интервал занчений
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;//я без понятия нахер это надо честно говоря , но оно есть и оно живое
            Accuracy = accuracy;// Точность - чем больше значение этой переменной тем больше шанс
                                //попадения по врагу
        }
        // метод который изменяет характеристики оружия в зависимости от прочности
        public float Durability_check()
        {
            if (Durability >= 70)
            {
                return 1;
            }
            else if (Durability >= 40)
            {
                return 0.7f;
            }
            else if (Durability > 0)
            {
                return 0.4f;
            }
            else
            {
                //  а точнее метод отвечаюший за степень поломки оружия
                Alive = false;
                Console.WriteLine("Оружие сломалось");
                return 0;

            }
        }

        public virtual float Hit(Unit unit)
        {
            Durability--;
            if (!Alive)
            {
                return 0;
            }
            else
            {
                float CritChance = 20;
                float CritDamage = 1;
                int x = new Random().Next(1, 100);
                if (x >= Accuracy)
                {
                    return 0;
                }
                else
                {
                    float Damage = new Random().Next(MinDamage, MaxDamage);
                    Damage += Level * 5;
                    x = new Random().Next(1, 100);
                    if (x <= CritChance)
                    {
                        Damage += Damage * CritDamage;
                    }
                    return Damage * Durability_check();
                }
            }

        }
        
        public void LevelUp()
        {
            if (Level < 10)
            {
                Level += 1;
            }
            else
            {
                Console.WriteLine($"У {Name} Максимальный левел");
            }
        }
    }
}
