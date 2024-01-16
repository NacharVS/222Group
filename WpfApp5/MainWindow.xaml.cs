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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double result;
        double first;
        double second;
        double move;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            rabocheepole.Content += "0";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            rabocheepole.Content += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            rabocheepole.Content += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            rabocheepole.Content += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            rabocheepole.Content += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            rabocheepole.Content += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            rabocheepole.Content += "6";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            rabocheepole.Content += "9";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            rabocheepole.Content += "8";
        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            rabocheepole.Content += "7";
        }

        private void btnplus_Click(object sender, RoutedEventArgs e)
        {
            move = 1;
            first = Convert.ToInt32(rabocheepole.Content);
            rabocheepole.Content = "";
        }

        private void btnminus_Click(object sender, RoutedEventArgs e)
        {
            move = 2;
            first = Convert.ToInt32(rabocheepole.Content);
            rabocheepole.Content = "";
        }

        private void btnymnojit_Click(object sender, RoutedEventArgs e)
        {
            move = 3;
            first = Convert.ToInt32(rabocheepole.Content);
            rabocheepole.Content = "";
        }

        private void btndelit_Click(object sender, RoutedEventArgs e)
        {
            move = 4;
            first = Convert.ToInt32(rabocheepole.Content);
            rabocheepole.Content = "";
        }

        private void btneq_Click(object sender, RoutedEventArgs e)
        {
            second = Convert.ToInt32(rabocheepole.Content);
            switch (move) {
                case 1:
                    result = first + second;
                    break;
                case 2:
                    result = first - second;
                    break;
                case 3:
                    result = first * second;
                    break;
                case 4:
                    result = first / second;
                    break;
            }
                         
            rabocheepole.Content = result;
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            rabocheepole.Content = "";
            first = 0;
            second = 0;
            result = 0;
            move = 0;
        }
    }
}
