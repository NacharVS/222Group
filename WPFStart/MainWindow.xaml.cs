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
using System.IO;

namespace WPFStart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users; 
        public MainWindow()
        {
            users = new List<User>();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User(txtName.Text, txtSurname.Text));
            txtName.Clear();
            txtSurname.Clear();
            ListBoxRefresh();
        }

        private void btn1_MouseEnter(object sender, MouseEventArgs e)
        {
           
        }

        private void btn1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void list1_Loaded(object sender, RoutedEventArgs e)
        {


        }

        private void ListBoxRefresh()
        {
            list1.Items.Clear();
            foreach (User user in users)
            {
                list1.Items.Add(user.Surname);
            }
        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(list1.SelectedItem != null)
            {
                var user = users.Find(x => x.Surname ==
                list1.SelectedItem.ToString());
                lbl1.Content = user.Name;
                lbl2.Content = user.Surname;
            }
        }

        private void Button_Click_1(System.Object sender, System.Windows.RoutedEventArgs e)
        {
            Method();
        }

        void Method()
        {
            while (File.Exists(@"C:\Users\Vadim.Nacharov\Desktop\testdoc.txt"))
            {

            }
            MessageBox.Show("FILE DELETED OR NAME CHANGED");
        }
    }
}
