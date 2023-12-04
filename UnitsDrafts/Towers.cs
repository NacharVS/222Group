using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Towers
    {
        private string _twname;
        private int _twhealth;
        private int _twmaxhealth;
        public string TWname
        {
            get { return _twname; }
            set { _twname = value; }
        }
        public int Twhealth
        {
            get { return _twhealth; }
            set { _twhealth = value; }
        }
        public int Twmaxhealth
        {
            get { return _twmaxhealth; }
            set
            {
                
                if (value > Twmaxhealth)
                {
                    value = Twmaxhealth;
                }
            }
        }
        public Towers(string TowerName, int TowerMaxHealth)
        {
            _twname = TowerName;
            _twmaxhealth = TowerMaxHealth;
        }

    }
}
