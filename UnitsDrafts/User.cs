using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class User<T>
    {
        public int Id { get; set; }
        public T Field { get; set; }
    }
}
