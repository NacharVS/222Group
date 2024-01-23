using System;
using System.Collections;
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

namespace registration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> people;
        List<TeamSpirit> teams;
        public MainWindow()
        {
            people = new List<Person>();
            teams = new List<TeamSpirit>();
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            people.Add(new Person(txtName.Text, txtSurname.Text, txtLogin.Text));
            txtName.Clear();
            txtSurname.Clear();
            txtLogin.Clear();
            ListBoxRefresh();
            TeamBoxRefresh();
        }
        private void ListBoxRefresh()
        {
            lstLogin.Items.Clear();
            foreach (Person person in people)
            {
                lstLogin.Items.Add(person.Login);
            }
        }
        private void TeamBoxRefresh()
        {
            lstTeam.Items.Clear();
            foreach (TeamSpirit team in teams)
            {
                lstTeam.Items.Add(team.Team);
            }
        }

        private void CreateTeam_Click(object sender, RoutedEventArgs e)
        {
            lstLogin.Items.Clear();
            foreach (Person person in people)
            {
                lstTeam.Items.Add(person.Login);
            }
        }
    }
}
