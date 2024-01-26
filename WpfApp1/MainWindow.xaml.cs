using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace WpfApp1
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

        string bbbbb;
        double qqqqq;



        private void a1_Click(object sender, RoutedEventArgs e)
        {
            
            lbl.Content += "1";
            
        }

        private void a2_Click(object sender, RoutedEventArgs e)
        { 
            lbl.Content += "2";
        }
        

        private void a3_Click(object sender, RoutedEventArgs e)
        {
            lbl.Content += "3";
        }

        private void ravno_Click(object sender, RoutedEventArgs e)
        {
            if (qqqqq == 1)
            {
                double cones = Convert.ToDouble(bbbbb) + Convert.ToDouble(lbl.Content);
                lbl.Content = Convert.ToString(cones);
                
            }
            if (qqqqq == 2)
            {
                double cones = Convert.ToDouble(bbbbb) - Convert.ToDouble(lbl.Content);
                lbl.Content = Convert.ToString(cones);
            }
            if (qqqqq == 3)
            {
                double cones = Convert.ToDouble(bbbbb) * Convert.ToDouble(lbl.Content);
                lbl.Content = Convert.ToString(cones);
                
            }
            if (qqqqq == 4)
            {
                double cones = Convert.ToDouble(bbbbb) / Convert.ToDouble(lbl.Content);
                lbl.Content = Convert.ToString(cones);
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            qqqqq = 2;
            bbbbb= Convert.ToString(lbl.Content);
            lbl.Content = null;

        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            qqqqq = 1;
            bbbbb = Convert.ToString(lbl.Content);
            lbl.Content = null;
        }

        private void a4_Click(object sender, RoutedEventArgs e)
        {
            lbl.Content += "4";
        }

        private void a5_Click(object sender, RoutedEventArgs e)
        {
            lbl.Content += "5";
        }

        private void a6_Click(object sender, RoutedEventArgs e)
        {
            lbl.Content += "6";
        }

        private void a7_Click(object sender, RoutedEventArgs e)
        {
            lbl.Content += "7";
        }

        private void a8_Click(object sender, RoutedEventArgs e)
        {
            lbl.Content += "8";
        }

        private void a9_Click(object sender, RoutedEventArgs e)
        {
            lbl.Content += "9";
        }

        private void a0_Click(object sender, RoutedEventArgs e)
        {
            lbl.Content += "0";
        }

        private void steret_Click(object sender, RoutedEventArgs e)
        {
            qqqqq = 5;
            lbl.Content = null;
        }

        private void umnojit_Click(object sender, RoutedEventArgs e)
        {
            qqqqq = 3;
            bbbbb = Convert.ToString(lbl.Content);
            lbl.Content = null;
        }

        private void delit_Click(object sender, RoutedEventArgs e)
        {
            qqqqq = 4;
            bbbbb = Convert.ToString(lbl.Content);
            lbl.Content = null;
        }
    }
}
