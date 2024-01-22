using System.IO.MemoryMappedFiles;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace teams
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Member> members;
        public MainWindow()
        {
            members = new List<Member>();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            members.Add(new Member(txtlog.Text, txtname.Text, txtsurname.Text, txtage.Text));
            txtlog.Clear();
            txtname.Clear();
            txtsurname.Clear();
            txtage.Clear();
            LogBoxRefresh();
        }
        private void LogBoxRefresh()
        {
            LogBox.Items.Clear();
            foreach (Member member in members) 
            {
                LogBox.Items.Add(member.Login);
            }
        }

        private void LogBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(LogBox.SelectedItem != null) 
            {
                var member = members.Find(x => x.Login ==
                LogBox.SelectedItem.ToString());
                lbl1.Content = member.Login;
                lbl2.Content = member.Name;
                lbl3.Content = member.Surname;
                lbl4.Content = member.Age;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var member = members.Find(x => x.Login ==
            LogBox.SelectedItem.ToString());
            T1box.Items.Add(member.Login);
            LogBox.Items.Remove(member.Login);
        }

        private void T1box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (T1box.SelectedItem != null)
            {
                var member = members.Find(x => x.Login ==
                T1box.SelectedItem.ToString());
                lbl1.Content = member.Login;
                lbl2.Content = member.Name;
                lbl3.Content = member.Surname;
                lbl4.Content = member.Age;
            }
        }

        private void T2Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (T2Box.SelectedItem != null)
            {
                var member = members.Find(x => x.Login ==
                T2Box.SelectedItem.ToString());
                lbl1.Content = member.Login;
                lbl2.Content = member.Name;
                lbl3.Content = member.Surname;
                lbl4.Content = member.Age;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (T1box.SelectedItem != null)
            {
                var member = members.Find(x => x.Login ==
                T1box.SelectedItem.ToString());
                LogBox.Items.Add(member.Login);
                T1box.Items.Remove(member.Login);
            }
            else
            {
                var member1 = members.Find(x => x.Login ==
                T2Box.SelectedItem.ToString());
                LogBox.Items.Add(member1.Login);
                T2Box.Items.Remove(member1.Login);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var member = members.Find(x => x.Login ==
            LogBox.SelectedItem.ToString());
            T2Box.Items.Add(member.Login);
            LogBox.Items.Remove(member.Login);
        }
    }
}