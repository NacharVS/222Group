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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zadanie
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<logins> listlog;
        List<string> comandos;
        logins user;
        public MainWindow()
        {
            InitializeComponent();
            this.listlog = new List<logins>();
            this.comandos = new List<string>();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void listchistis()
        {
            logins228.Items.Clear();
            foreach (logins umama in listlog)
            {
                logins228.Items.Add(umama.nama);
            }
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            if (namme.Text != "" && surnamme.Text != "")
            {
                listlog.Add(new logins(namme.Text, surnamme.Text));
                surnamme.Clear();
                namme.Clear();
                listchistis();
            }
            
            if(comy.Text != "")
            {
                cim.Text = comy.Text;
                comy.Clear();
                label3.Text = null;
                comy.Margin = new Thickness(0, 0, 0, 50000);

            }
        }

        private void logins228_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(logins228.SelectedItem != null)
            {
                commanda.Items.Add(logins228.SelectedItem);
                logins228.Items.Remove(logins228.SelectedItem);
            }
             
        }

        private void commanda_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(commanda.SelectedItem != null)
            {
                logins228.Items.Add(commanda.SelectedItem);
                commanda.Items.Remove(commanda.SelectedItem);
            }
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
