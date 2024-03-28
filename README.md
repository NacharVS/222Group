using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace Diablo
{
    /// <summary>
    /// Логика взаимодействия для ChoiceClass.xaml
    /// </summary>
    public partial class ChoiceClass : Page
    {

        private SoundPlayer SoundEnter = null;
        public ChoiceClass()
        {
            InitializeComponent();
            SoundEnter = new SoundPlayer(); //ЗВУК ПРИ НАВЕДЕНИИ МЫШИ НА КНОПКУ
            SoundEnter.SoundLocation = "EnterMouseSound.wav";
        }
        private void Warrior_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri uri = new Uri("/Images/Warrior.jpg", UriKind.Relative);
            ImageHero.Source = new BitmapImage(uri);
            SoundEnter.Play();
        }
        private void Rogue_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri uri = new Uri("/Images/Rogue.jpg", UriKind.Relative);
            ImageHero.Source = new BitmapImage(uri);
            SoundEnter.Play();
        }
        private void Wizard_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri uri = new Uri("/Images/Wizard.jpg", UriKind.Relative);
            ImageHero.Source = new BitmapImage(uri);
            SoundEnter.Play();
        }
        private void Sound_MouseEnter(object sender, MouseEventArgs e)
        {
            SoundEnter.Play();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateHero());
            App.Current.Resources["HeroClass"] = Warrior.Content;
        }

        private void Rogue_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateHero());
            App.Current.Resources["HeroClass"] = Rogue.Content;
        }

        private void Wizard_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateHero());
            App.Current.Resources["HeroClass"] = Wizard.Content;
        }
    }
}
