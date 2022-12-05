using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using WeltraumShooter2022_2023.CLASSES;
using WeltraumShooter2022_2023.GUI;
using WeltraumShooter.Design;

namespace WeltraumShooter2022_2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {     

        
        homePage HomePage = new homePage();
        gamePage GamePage = new gamePage();
                
        
        public MainWindow()
        {
            InitializeComponent();
            this.contentControll.Content = HomePage;
            HomePage.getMainWindow = this;
        }
  
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Global.spaceShip.LastPressedKey = e;
        }
        
        public void changeContent()
        {
            this.contentControll.Content = GamePage;
        }

        private void HS_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
