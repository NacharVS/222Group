using System.Text;

namespace UnitsDrafts
{
    internal class Axe : Weapon
    {
        private int _swordlvl;
        public Axe() : base("Топорик", 6, 11, 8, 85, 800, false, 100)
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
                Bleede = false;
                Console.WriteLine($"SwordLVL: {SWORDLVL} Name:{WepName} MinDMG: {MinDamage} MaxDMG: {MaxDamage} " +
                                  $"AttackSpeed: {AttackSpeed} Accuracy: {Accuracy} Durability: {Durability} Bleede: {Bleede}");
            }
            else
            {
                Console.WriteLine("Уровень прокачки меча максимальный");
            }
        }
    }
}