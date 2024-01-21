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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string field;
        double num1, num2;
        string action;
        double result;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            textbox.Text += "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textbox.Text += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textbox.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textbox.Text += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textbox.Text += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textbox.Text += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textbox.Text += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textbox.Text += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textbox.Text += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textbox.Text += "9";
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            textbox.Text = "";
            num1 = 0;
            num2 = 0;
            result = 0;
            action = "";
        }

        private void Button_Click_Equal(object sender, RoutedEventArgs e)
        {
            num2 = double.Parse(textbox.Text);
            switch (action)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "×":
                    result = num1 * num2;
                    break;
                case "÷":
                    result = num1 / num2;
                    break;
            }

            textbox.Text = Convert.ToString(result);
        }

        private void Button_Click_Addition(object sender, RoutedEventArgs e)
        {
            action = "+";
            num1 = double.Parse(textbox.Text);
            textbox.Text = "";
        }

        private void Button_Click_Substraction(object sender, RoutedEventArgs e)
        {
            action = "-";
            num1 = double.Parse(textbox.Text);
            textbox.Text = "";
        }

        private void Button_Click_Multiplication(object sender, RoutedEventArgs e)
        {
            action = "×";
            num1 = double.Parse(textbox.Text);
            textbox.Text = "";
        }

        private void Button_Click_Division(object sender, RoutedEventArgs e)
        {
            action = "÷";
            num1 = double.Parse(textbox.Text);
            textbox.Text = "";
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            field = textbox.Text;
            field = field.Remove(field.Length - 1);
            textbox.Text = field;
        }
    }
}
