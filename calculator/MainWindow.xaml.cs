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

namespace calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int a;
        public int b;
        public string c;
        public int d;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (c == "+")
            {
                screen.Content += "9";
                b = Convert.ToInt32(screen.Content);
            }
            else if (screen.Content == "0")
            {
                screen.Content = "";
                screen.Content += "9";
                a = Convert.ToInt32(screen.Content);
            }
            else
            {
                screen.Content += "9";
                a = Convert.ToInt32(screen.Content);
            }
            e
        }

        private void num7_Click(object sender, RoutedEventArgs e)
        {
            if (c == "+")
            {
                screen.Content += "7";
                b = Convert.ToInt32(screen.Content);
            }
            else if (screen.Content == "0")
            {
                screen.Content = null;
                screen.Content += "7";
                a = Convert.ToInt32(screen.Content);
            }
            else
            {
                screen.Content += "7";
                a = Convert.ToInt32(screen.Content);
            }
        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            if (c == "+")
            {
                screen.Content += "8";
                b = Convert.ToInt32(screen.Content);
            }
            else if (screen.Content == "0")
            {
                screen.Content = null;
                screen.Content += "8";
                a = Convert.ToInt32(screen.Content);
            }
            else
            {
                screen.Content += "8";
                a = Convert.ToInt32(screen.Content);
            }
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            if (c == "+")
            {
                screen.Content += "6";
                b = Convert.ToInt32(screen.Content);
            }
            else if (screen.Content == "0")
            {

                screen.Content = null;
                screen.Content += "6";
                a = Convert.ToInt32(screen.Content);
            }
            else
            {
                screen.Content += "6";
                a = Convert.ToInt32(screen.Content);
            }
        }

        private void num_Click(object sender, RoutedEventArgs e)
        {
            if (c == "+")
            {
                screen.Content += "3";
                b = Convert.ToInt32(screen.Content);
            }
            else if (screen.Content == "0")
            {

                screen.Content = null;
                screen.Content += "3";
                a = Convert.ToInt32(screen.Content);
            }
            else
            {
                screen.Content += "3";
                a = Convert.ToInt32(screen.Content);
            }
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            if (c == "+")
            {
                screen.Content += "2";
                b = Convert.ToInt32(screen.Content);
            }
            else if (screen.Content == "0")
            {
                screen.Content = null;
                screen.Content += "2";
                a = Convert.ToInt32(screen.Content);
            }
            else
            {
                screen.Content += "2";
                a = Convert.ToInt32(screen.Content);
            }
        }

        private void num1_Click(object sender, RoutedEventArgs e)
        {
            if (c == "+")
            {
                screen.Content += "1";
                b = Convert.ToInt32(screen.Content);
            }
            else if (screen.Content == "0")
            {
                screen.Content = null;
                screen.Content += "1";
                a = Convert.ToInt32(screen.Content);
            }
            else
            {
                screen.Content += "1";
                a = Convert.ToInt32(screen.Content);
            }
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            if (c == "+")
            {
                screen.Content += "4";
                b = Convert.ToInt32(screen.Content);
            }
            else if (screen.Content == "0")
            {
                screen.Content = null;
                screen.Content += "4";
                a = Convert.ToInt32(screen.Content);
            }
            else
            {
                screen.Content += "4";
                a = Convert.ToInt32(screen.Content);
            }
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            if(c == "+")
            {
                screen.Content += "5";
                b = Convert.ToInt32(screen.Content);
            }
            else if (screen.Content == "0")
            {
                screen.Content = null;
                screen.Content += "5";
                a = Convert.ToInt32(screen.Content);
            }
            else
            {
                screen.Content += "5";
                a = Convert.ToInt32(screen.Content);
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(screen.Content);
            screen.Content = null;
            c = "+";
        }

        private void ravno_Click(object sender, RoutedEventArgs e)
        {
            if(c == "+" && a > 1 && b > 1) 
            {
                d = a + b;
                screen.Content = Convert.ToString(d);
            }
        }
    }
}
