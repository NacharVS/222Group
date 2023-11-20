namespace UnitsDrafts
{
    internal class Sword : Weapon
    {
        private int _swordlvl;
        public Sword() : base("Mech", 2, 6, 8, 80, 800, false)
        {
            _swordlvl = 0;
        }
        public int SWORDLVL
        {
            get { return _swordlvl; }
            set { _swordlvl = value; }
        }
        public void SwordUpgrade()
        {
            if (SWORDLVL < 6)
            {
                SWORDLVL++;
                MinDamage += 3;
                MaxDamage += 3;
                AttackSpeed += 2;
                Accuracy += 3;
                Durability += 50;
                Console.WriteLine($"SwordLVL: {SWORDLVL} Name:{WepName} MinDMG: {MinDamage} MaxDMG: {MaxDamage} " +
                                  $"AttackSpeed: {AttackSpeed} Accuracy: {Accuracy} Durability: {Durability}");
            }
            else
            {
                Console.WriteLine("Уровень прокачки меча максимальный");
            }
        }
    }
}