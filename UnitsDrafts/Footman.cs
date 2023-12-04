using UnitsDrafts.Items;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        public delegate void InflictDamageDelegate(Unit unit, int damage);
        

        public InflictDamageDelegate inflictDamage;
        private int _defence;

        private Weapon _weapon;

        public Footman() : base("Footman", 60, 5, 2, 6)
        {
            _weapon = new Sword();
        }



        public int Defence 
        {
            get {  return _defence; }
            set { _defence = value; }
        }


        public void InflictDamage(Unit unit)
        {
            BaseInfo();
            inflictDamage(unit, _weapon.Hit());
            BaseInfo();
        }

    }
}


//unit.Health = unit.Health - _damage;
//unit.Defence -= _damage;
//unit.Health = +Defence;