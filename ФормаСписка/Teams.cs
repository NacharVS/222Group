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

        public int UserCount;

        public List<UserInfo> TeamStruct = new List<UserInfo>();

        public Teams(string team, int userCount) 
        {
            TeamName = team;
            UserCount = userCount;
        }  
    }
}
