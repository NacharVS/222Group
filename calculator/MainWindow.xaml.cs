using System.Data;
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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var CurrentButton = sender as Button;
            txt.Text += CurrentButton.Content;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var equal = new DataTable();
            txt.Text = equal.Compute(txt.Text, "").ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txt.Text = "";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var str = "";
            for (int i = 0; i < txt.Text.Length - 1; i++)
            {
                str += txt.Text[i];
            }
            txt.Text = str;
        }
    }
}