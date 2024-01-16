using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_Loaded(object sender, RoutedEventArgs e)
        { 
        }

        private void AddToList_Click(object sender, RoutedEventArgs e)
        {
            User user = new User(txtname1.Text, txtsurname.Text, txtEmail.Text,txtPassword.Text,txtAge.Text) ;
            users.Add(user);
            txtname1.Clear();
            txtsurname.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtAge.Clear();
            refresh();

        }
        private void refresh()
        {
            txtlistbox.Items.Clear();
            foreach (User user in users)
            {
                txtlistbox.Items.Add(user.Name + " " + user.Surname);
            }
        }


        private void txtlistbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = txtlistbox.SelectedIndex;
            User user = users[index];
            userinfo.Content = user.Name+ " " +  user.Surname+" " + user.Email+ " " + user.Password + " " + user.Age;
        }
    }
}
