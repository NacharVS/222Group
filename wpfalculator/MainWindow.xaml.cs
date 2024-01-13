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

namespace wpfalculator
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

        string FirstNum;
        int sign;


        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            Almax.Content += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            Almax.Content += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            Almax.Content += "9";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Almax.Content += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Almax.Content += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Almax.Content += "6";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Almax.Content += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Almax.Content += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Almax.Content += "3";
        }

        private void btnAC_Click(object sender, RoutedEventArgs e)
        {
            Almax.Content = null;
        }

        
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            sign = 1;
            FirstNum = Convert.ToString(Almax.Content);
            Almax.Content = null;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            Almax.Content += "0";
        }

        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            Almax.Content += ".";
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            if (sign == 1)
            {
                int itog = Convert.ToInt32(FirstNum) + Convert.ToInt32(Almax.Content);
                Almax.Content = Convert.ToString(itog);
            }
            if (sign == 2)
            {
                int itog = Convert.ToInt32(FirstNum) - Convert.ToInt32(Almax.Content);
                Almax.Content = Convert.ToString(itog);
            }
            if (sign == 3)
            {
                int itog = Convert.ToInt32(FirstNum) * Convert.ToInt32(Almax.Content);
                Almax.Content = Convert.ToString(itog);
            }
            if (sign == 4)
            {
                double itog = Convert.ToDouble(FirstNum) / Convert.ToDouble(Almax.Content);
                Almax.Content = Convert.ToString(itog);
            }
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            sign = 2;
            FirstNum = Convert.ToString(Almax.Content);
            Almax.Content = null;
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            sign = 3;
            FirstNum = Convert.ToString(Almax.Content);
            Almax.Content = null;
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            sign = 4;
            FirstNum = Convert.ToString(Almax.Content);
            Almax.Content = null;
        }
    }
}
