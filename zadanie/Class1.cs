using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace zadanie
{
    internal class logins
    {
        public logins(string nama, string famile)
        {
            this.nama = nama;
            this.famile = famile;
        }

        public string nama { get; set; }
        public string famile { get; set; }
    }
}
