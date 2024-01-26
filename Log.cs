using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Log
    {

            public Log(string Login, string Password)
            {
                this.Login = Login;
                this.Password = Password;
            }

            public string Login { get; set; }
            public string Password { get; set; }

    }
}
