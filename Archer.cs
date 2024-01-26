namespace UnitsDrafts
{

    internal class Archer : Unit
    {
        private int _speed;

        public Archer() : base("Arch1", 16, 5, 7, 3)
        {
        }

        

        public override void BaseInfo()
        {
            if (Health < 16)
            {
                _speed += 4;
            }
            else
            {
                _speed = 11;
            }
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Speed: {_speed} ");
        }
    }
}