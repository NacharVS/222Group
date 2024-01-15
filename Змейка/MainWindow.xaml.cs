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

namespace Змейка
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        public void SnakeInit()
        {
  
            Rectangle SnakeHead = new Rectangle();
            SnakeHead.Width = 53;
            SnakeHead.Height = 53;
            SnakeHead.Fill = Brushes.Green;

            GameField.Children.Add(SnakeHead);
            Grid.SetColumn(SnakeHead, 4);
            Grid.SetRow(SnakeHead, 4);
            
        }

        private void Btn_Start(object sender, RoutedEventArgs e)
        {
            SnakeInit();
            btnStart.IsEnabled = false;  
        }
    }
}
