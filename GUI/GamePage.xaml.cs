using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WeltraumShooter2022_2023.CLASSES;

namespace WeltraumShooter2022_2023.GUI
{
    /// <summary>
    /// Interaktionslogik für Page1.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        public GamePage()
        {
            InitializeComponent();
        }

        private void SpaceCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Global.SpaceCanvas = SpaceCanvas;
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Go_Btn.Visibility = Visibility.Hidden;
            MAIN.StartGame();     
        }
    }
}
