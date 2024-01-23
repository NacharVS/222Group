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
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Пустой логин!");
                lstLogin.Items.Clear();
            }
            else
            if (txtLogin.Text != null) 
            {
                people.Add(new Person(txtName.Text, txtSurname.Text, txtLogin.Text));
                teams.Add(new TeamSpirit(txtTeam.Text));
                TeamName.Text = txtTeam.;
                txtName.Clear();
                txtSurname.Clear();
                txtLogin.Clear();
                txtTeam.Clear();
                ListBoxRefresh();
            }
        }
        private void ListBoxRefresh()
        {
            lstLogin.Items.Clear();
            foreach (Person person in people)
            {
                lstLogin.Items.Add(person.Login);
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


        private void DeletePerson_Click(object sender, RoutedEventArgs e)
        {
            lstLogin.Items.Add(lstTeam.SelectedItems);
        }
    }
}
