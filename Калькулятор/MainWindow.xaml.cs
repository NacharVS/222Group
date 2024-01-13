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

namespace Калькулятор
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

        static int sign; // 1 = +, 2 = -, 3 = *, 4 = /. //
        static double Num1Save;
        static double Num2;
        static bool ClickAlready = false;

        public void PlusOnPanel()
        {
            Panel.Text = "+";
        }

        public void MinusOnPanel()
        {
            Panel.Text = "-";
        }

        public void MultiplyOnPanel()
        {
            Panel.Text = "*";
        }

        public void DevideOnPanel()
        {
            Panel.Text = "/";
        }
        public void FillNum()
        {           
            Panel.Text = $"{Num2}";         
        }
        private void btnAC_Click(object sender, RoutedEventArgs e)
        {
            Num2 = 0;
            FillNum();
            ClickAlready = false;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (Num2 == 0)
            {
                Num2 += 1;
            }
            else
            {
                Num2 *= 10;
                Num2 += 1;
            }
            FillNum();
        }
        

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Num2 == 0)
            {
                Num2 += 2;
            }
            else
            {
                Num2 *= 10;
                Num2 += 2;
            }
            FillNum();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (Num2 == 0)
            {
                Num2 += 3;
            }
            else
            {
                Num2 *= 10;
                Num2 += 3;
            }
            FillNum();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (Num2 == 0)
            {
                Num2 += 4;
            }
            else
            {
                Num2 *= 10;
                Num2 += 4;
            }
            FillNum();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (Num2 == 0)
            {
                Num2 += 5;
            }
            else
            {
                Num2 *= 10;
                Num2 += 5;
            }
            FillNum();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (Num2 == 0)
            {
                Num2 += 6;
            }
            else
            {
                Num2 *= 10;
                Num2 += 6;
            }
            FillNum();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (Num2 == 0)
            {
                Num2 += 7;
            }
            else
            {
                Num2 *= 10;
                Num2 += 7;
            }
            FillNum();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (Num2 == 0)
            {
                Num2 += 8;
            }
            else
            {
                Num2 *= 10;
                Num2 += 8;
            }
            FillNum();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (Num2 == 0)
            {
                Num2 += 9;
            }
            else
            {
                Num2 *= 10;
                Num2 += 9;
            }
            FillNum();
        }


        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {      
            if (ClickAlready == false)
            {
                sign = 1;
                Num1Save = Num2;
                Num2 = 0;
                PlusOnPanel();
                ClickAlready = true;
            }
            else
            {
                return;
            }
        
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (sign)
            {
                case (1): Num2 = Num1Save + Num2; break;
                case (2): Num2 = Num1Save - Num2; break;
                case (3): Num2 = Num1Save * Num2; break;
                case (4): Num2 = Num1Save / Num2; break;
            }

            ClickAlready = false;
            FillNum();
        }
   

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            Num2 *= 10;
            FillNum();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (ClickAlready == false)
            {
                sign = 2;
                Num1Save = Num2;
                Num2 = 0;
                MinusOnPanel();
                ClickAlready = true;
            }
            else
            {
                return;
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (ClickAlready == false)
            {
                sign = 3;
                Num1Save = Num2;
                Num2 = 0;
                MultiplyOnPanel();
                ClickAlready = true;
            }
            else
            {
                return;
            }
        }

        private void btnDevide_Click(object sender, RoutedEventArgs e)
        {
            if (ClickAlready == false)
            {
                sign = 4;
                Num1Save = Num2;
                Num2 = 0;
                DevideOnPanel();
                ClickAlready = true;
            }
            else
            {
                return;
            }
        }

        private void btnChangeSign_Click(object sender, RoutedEventArgs e)
        {
            Num2 *= -1;
            FillNum();
        }

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            Num1Save = Num2;
            Num2 = Num1Save / 100;    
            FillNum();
        }
    }
}
