namespace TestLibrary
{
    public interface IWeapon
    {
        public int MinDamage { get; }
        public int MaxDamage { get; }

        void Shoot(); 
    }
}
