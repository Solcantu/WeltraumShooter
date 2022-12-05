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
using WeltraumShooter2022_2023;

namespace WeltraumShooter.Design
{
    /// <summary>
    /// Interaktionslogik für homePage.xaml
    /// </summary>
    public partial class homePage : UserControl
    {
        private MainWindow mainWindow;
        public MainWindow getMainWindow
        {
            set { mainWindow = value; }
        }
        
        //WeltraumShooter2022_2023.MainWindow mainWindow = new MainWindow();
        public homePage()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
           mainWindow.changeContent();   
        }
    }
}
