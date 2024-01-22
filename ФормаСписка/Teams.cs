using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ФормаСписка
{
    internal class Teams
    {
        public string TeamName;

        public int TeamCount;

        public Teams(string team, int teamCount) 
        {
            TeamName = team;
            TeamCount = teamCount;
        }  
    }
}
