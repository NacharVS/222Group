namespace UnitsDrafts.Items
{
    internal class Sword : Weapon
    {
        public Sword(int minDamage, int maxDamage, int attackspeed, int accuracy, int durability) : base(minDamage, maxDamage, attackspeed, accuracy, durability)
        {
        }
        public Sword() : base(2, 6, 8, 80, 800)
        {
        }
        public override int Hit()
        {
            
        }
    }
}
