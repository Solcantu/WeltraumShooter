using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using WeltraumShooter2022_2023.CLASSES;
using WeltraumShooter2022_2023.GUI;

namespace WeltraumShooter2022_2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {     
        GamePage gamePage = new GamePage();
        
        public MainWindow()
        {
            InitializeComponent();           
        }
  
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Global.spaceShip.LastPressedKey = e;
        }

        private void Start_Btn_Click(object sender, RoutedEventArgs e)
        {
            Start_Btn.IsEnabled = false;           
            supeFrame.Content = gamePage;
        }

        private void HS_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Opt_Btn_MouseMove(object sender, MouseEventArgs e)
        {                      
        }


    }
}
