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
using System.Windows.Threading;

namespace WeltraumShooter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SpaceShip player_ship;

        public MainWindow()
        {
            InitializeComponent();
            Global.SpaceCanvas = SpaceCanvas;
            player_ship = new SpaceShip();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromTicks(100);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            player_ship.Draw();
                       
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            player_ship.keyselect(sender,e);   
        }

        private void SpaceCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
