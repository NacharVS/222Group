using System.Collections.Generic;
using System.IO.Packaging;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Navigation;

namespace ФормаСписка
{
    internal class UserInfo
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        public string Login { get; set; }

        public string AllName;

        public UserInfo(string name, string surname, string login)
        {
            Name = name;
            Surname = surname;
            Login = login;
            AllName = Name + " " + Surname;           
        }    
    }
}
