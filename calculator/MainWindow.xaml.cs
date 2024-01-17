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

        string FirstNum;
        int sign;
        int a;
        int b;
        int c;


        private void num_1_Click(object sender, RoutedEventArgs e)
        {
            screan.Content += "1";
        }

        private void num_6_Click(object sender, RoutedEventArgs e)
        {
            screan.Content += "6";
        }

        private void num_7_Click(object sender, RoutedEventArgs e)
        {
            screan.Content += "7";
        }

        private void num_8_Click(object sender, RoutedEventArgs e)
        {
            screan.Content += "8";
        }

        private void num_9_Click(object sender, RoutedEventArgs e)
        {
            screan.Content += "9";
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            sign = 4;
            FirstNum = Convert.ToString(screan.Content);
            screan.Content = null;
        }

        private void num_4_Click(object sender, RoutedEventArgs e)
        {
            screan.Content += "4";
        }

        private void num_5_Click(object sender, RoutedEventArgs e)
        {
            screan.Content += "5";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            sign = 2;
            FirstNum = Convert.ToString(screan.Content);
            screan.Content = null;
        }

        private void num_2_Click(object sender, RoutedEventArgs e)
        {
            screan.Content += "2";
        }

        private void num_3_Click(object sender, RoutedEventArgs e)
        {
            screan.Content += "3";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            sign = 1;
            FirstNum = Convert.ToString(screan.Content);
            screan.Content = null;
        }

        private void clean_Click(object sender, RoutedEventArgs e)
        {
            screan.Content = "";
        }

        private void num_0_Click(object sender, RoutedEventArgs e)
        {
            screan.Content += "0";
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            sign = 3;
            FirstNum = Convert.ToString(screan.Content);
            screan.Content = null;
        }

        private void equally_Click(object sender, RoutedEventArgs e)
        {
            if (sign == 1)
            {
                int itog = Convert.ToInt32(FirstNum) + Convert.ToInt32(screan.Content);
                screan.Content = Convert.ToString(itog);
            }
            if (sign == 2)
            {
                int itog = Convert.ToInt32(FirstNum) - Convert.ToInt32(screan.Content);
                screan.Content = Convert.ToString(itog);
            }
            if (sign == 3)
            {
                int itog = Convert.ToInt32(FirstNum) * Convert.ToInt32(screan.Content);
                screan.Content = Convert.ToString(itog);
            }
            if (sign == 4)
            {
                double itog = Convert.ToDouble(FirstNum) / Convert.ToDouble(screan.Content);
                screan.Content = Convert.ToString(itog);
            }
        }
    }
}
