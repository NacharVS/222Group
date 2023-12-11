namespace TestLibrary
{
    public class Pistol : IWeapon
    {
        public int MinDamage => 2;
        public int MaxDamage => 7;

        public int Durability { get; set; }

        public void Shoot()
        {
            Console.WriteLine($"piu! Dealed {new Random().Next(MinDamage, MaxDamage)}");
        }
    }
}
