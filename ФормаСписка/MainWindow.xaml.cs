using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ФормаСписка
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<UserInfo> users;
        List<Teams> teams;

        public MainWindow()
        {
            users = new List<UserInfo>();
            teams = new List<Teams>();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new(txtName.Text, txtSurname.Text, txtLogin.Text));  //Добавляет в лмст users user'а по конструктуру UserInfo, Имя и Фамилия. В конструкторе AllName = Фамилия + Имя//
            txtName.Clear();
            txtSurname.Clear();     
            txtLogin.Clear();
            ListBoxRefresh();
        }

        private void ListBoxRefresh()
        {
            listBox.Items.Clear();
            foreach (UserInfo user in users)
            {
                listBox.Items.Add(user.Login);
            }
        }

        private void CreateCommand(object sender, RoutedEventArgs e)
        {
            listBoxCommandPreview.Items.Clear();
        }
    }
}
