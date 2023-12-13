using System.Reflection.Emit;
using Units_222_Draft.Stats;
using Units_222_Draft.units;

namespace Units_222_Draft.guns
{
    public interface IGun
    {
        public int MaxDamage { get { return MaxDamage * Level; } }
        public int MinDamage { get; set; }
        public string Name {  get; set; }
        public int Accuracy {  get; set; }
        public int Level { get; set; }
        public float Shoot();
    }
}
