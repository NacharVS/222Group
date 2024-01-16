using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Navigation;

namespace ФормаСписка
{
    internal class UserInfo
    {
        private string Name { get; set; }
        private string Surname { get; set; }

        public string AllName;

        public UserInfo(string name, string surname)
        {
            Name = name;
            Surname = surname;
            AllName = Name + " " + Surname;
        }

        
    }
}
