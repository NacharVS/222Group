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

        string field;
        double number_1, number_2;
        string action;
        double result;
        private void ButtonClick0(object sender, RoutedEventArgs e)
        {
            InputField.Text += "0";
        }

        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            InputField.Text += "1";
        }

        private void ButtonClick2(object sender, RoutedEventArgs e)
        {
            InputField.Text += "2";
        }

        private void ButtonClick3(object sender, RoutedEventArgs e)
        {
            InputField.Text += "3";
        }

        private void ButtonClick4(object sender, RoutedEventArgs e)
        {
            InputField.Text += "4";
        }

        private void ButtonClick5(object sender, RoutedEventArgs e)
        {
            InputField.Text += "5";
        }

        private void ButtonClick6(object sender, RoutedEventArgs e)
        {
            InputField.Text += "6";
        }

        private void ButtonClick7(object sender, RoutedEventArgs e)
        {
            InputField.Text += "7";
        }

        private void ButtonClick8(object sender, RoutedEventArgs e)
        {
            InputField.Text += "8";
        }

        private void ButtonClick9(object sender, RoutedEventArgs e)
        {
            InputField.Text += "9";
        }

        private void ButtonClickPoint(object sender, RoutedEventArgs e)
        {
            InputField.Text += ",";
        }

        private void ButtonClickPlus(object sender, RoutedEventArgs e)
        {
            action = "plus";
            number_1 = double.Parse(InputField.Text);
            InputField.Text = "";
        }

        private void ButtonClickMinus(object sender, RoutedEventArgs e)
        {
            action = "minus";
            number_1 = double.Parse(InputField.Text);
            InputField.Text = "";
        }

        private void ButtonClickMult(object sender, RoutedEventArgs e)
        {
            action = "mult";
            number_1 = double.Parse(InputField.Text);
            InputField.Text = "";
        }

        private void ButtonClickDivis(object sender, RoutedEventArgs e)
        {
            action = "divis";
            number_1 = double.Parse(InputField.Text);
            InputField.Text = "";
        }

        private void ButtonClickDel(object sender, RoutedEventArgs e)
        {
            field = InputField.Text;
            field = field.Remove(field.Length - 1);
            InputField.Text = field;
        }

        private void ButtonClickEqual(object sender, RoutedEventArgs e)
        {
            number_2 = double.Parse(InputField.Text);
            switch (action)
            {
                case "plus":
                    result = number_1 + number_2;
                    break;
                case "minus":
                    result = number_1 - number_2;
                    break;
                case "mult":
                    result = number_1 * number_2;
                    break;
                case "divis":
                    result = number_1 / number_2;
                    break;
            }

            InputField.Text = Convert.ToString(result);
        }

        private void ButtonClickClear(object sender, RoutedEventArgs e)
        {
            InputField.Text = "";
            number_1 = 0;
            number_2 = 0;
            result = 0;
            action = "";
        }
    }
}
