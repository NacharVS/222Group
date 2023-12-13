using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Units_222_Draft.guns
{
    public interface IGunsDurability
    {
        public bool Alive { get; set; }
        public int Durability {
            get
            {
                return Durability;
            }
            set
            {
                if (value < 0)
                {
                    Durability = 0;
                    Alive = false;
                }
                else
                    Durability = value;
            }
        }
        public float Durability_check();
    }
}
