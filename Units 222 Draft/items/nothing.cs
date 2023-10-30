
namespace Units_222_Draft.items
{
    internal class Nothing : Weapon
    {
        public Nothing(int minDamage, int maxDamage, int attackSpeed, int accuracy) : base(minDamage, maxDamage, attackSpeed, accuracy)
        {

        }
        public Nothing() : base(999999, 999999999,0, 0)
        {
        }
    }
}
