using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private int _mana;

        public Bishop() : base("Bishop", 40, 7)
        {
        }

        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }

        public void HealSomebody(Unit unit)
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{base.Name} Health: {base.Health}/{base.MaxHealth} Mana:{_mana}");
        }



    }
}
