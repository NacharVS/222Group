using System;
using System.Collections.Generic;
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

namespace Registration
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Member> members;
        public MainWindow()
        {
            members = new List<Member>();
            InitializeComponent();
        }

        private void LoginBoxRefresh()
        {
            LoginBox.Items.Clear();
            foreach (Member member in members)
            {
                LoginBox.Items.Add(member.Login);
            }
        }

        private void LoginBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LoginBox.SelectedItem != null)
            {
                var member = members.Find(x => x.Login ==
                LoginBox.SelectedItem.ToString());
                lable1.Content = member.Login;
                lable2.Content = member.Name;
                lable3.Content = member.Surname;
                lable4.Content = member.Age;
            }
        }

        private void TeamBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TeamBox1.SelectedItem != null)
            {
                var member = members.Find(x => x.Login ==
                TeamBox1.SelectedItem.ToString());
                lable1.Content = member.Login;
                lable2.Content = member.Name;
                lable3.Content = member.Surname;
                lable4.Content = member.Age;
            }
        }

        private void TeamBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TeamBox2.SelectedItem != null)
            {
                var member = members.Find(x => x.Login ==
                TeamBox2.SelectedItem.ToString());
                lable1.Content = member.Login;
                lable2.Content = member.Name;
                lable3.Content = member.Surname;
                lable4.Content = member.Age;
            }
        }

        private void Button_Click_Registration(object sender, RoutedEventArgs e)
        {
            members.Add(new Member(txtlogin.Text, txtname.Text, txtsurname.Text, txtage.Text));
            txtlogin.Clear();
            txtname.Clear();
            txtsurname.Clear();
            txtage.Clear();
            LoginBoxRefresh();
        }

        private void Button_Click_DeleteFromTeam(object sender, RoutedEventArgs e)
        {
            if (TeamBox1.SelectedItem != null)
            {
                var member = members.Find(x => x.Login ==
                TeamBox1.SelectedItem.ToString());
                LoginBox.Items.Add(member.Login);
                TeamBox1.Items.Remove(member.Login);
            }
            else
            {
                var member1 = members.Find(x => x.Login ==
                TeamBox2.SelectedItem.ToString());
                LoginBox.Items.Add(member1.Login);
                TeamBox2.Items.Remove(member1.Login);
            }
        }

        private void Button_Click_AddToTeam1(object sender, RoutedEventArgs e)
        {
            var member = members.Find(x => x.Login ==
            LoginBox.SelectedItem.ToString());
            TeamBox1.Items.Add(member.Login);
            LoginBox.Items.Remove(member.Login);
        }

        private void Button_Click_AddToTeam2(object sender, RoutedEventArgs e)
        {
            var member = members.Find(x => x.Login ==
            LoginBox.SelectedItem.ToString());
            TeamBox2.Items.Add(member.Login);
            LoginBox.Items.Remove(member.Login);
        }
    }
}
