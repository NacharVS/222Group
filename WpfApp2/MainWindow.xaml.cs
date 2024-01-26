using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
using System.Xml.Linq;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<Log> User ;
        List<string> comand;
        public MainWindow()
        {
          
            InitializeComponent();
            this.User = new List<Log>();
            this.comand = new List<string>();

        }

    
    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
            if (login1.Text != "" && password1.Text != "")
            {
                User.Add(new Log(login1.Text, password1.Text));
                password1.Clear();
                login1.Clear();
                ListBoxRefresh();
            }
        }

    private void password1_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void login1_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

        private void ListBoxRefresh()
        {
            User1.Items.Clear();
            foreach (Log user in User)
            {
                User1.Items.Add(user.Login);
            }
        }


        private void User1_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
            if (User1.SelectedItem != null)
            {
                comand1.Items.Add(User1.SelectedItem);
                User1.Items.Remove(User1.SelectedItem);
            }
        }

        private void comand1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comand1.SelectedItem != null)
            {
                User1.Items.Add(comand1.SelectedItem);
                comand1.Items.Remove(comand1.SelectedItem);
            }
        }



    }


}
