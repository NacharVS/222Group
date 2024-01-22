using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teams
{
    internal class Team
    {
        public string TeamName { get; set; }
        public Team (string teamName)
        {
            TeamName = teamName;
        }
    }
}
