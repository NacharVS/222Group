using Units_222_Draft.guns;

namespace Units_222_Draft.units
{
    internal class Shooter : Unit
    {

        public IGun gun;
        public Shooter(string name, float maxHealth, float defense, float speed) : base(name, maxHealth, defense, speed)
        {

        }
        
        public Shooter() : base("Shooter", 30f, 3, 10)
        {
            gun = new Revolver(12,4,100,"Revolver",true,100,1);
            ClassName = "Shooter";
        }
    }
}
