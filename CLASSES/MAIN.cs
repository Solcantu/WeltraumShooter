using System;
using System.Windows.Threading;

namespace WeltraumShooter2022_2023.CLASSES
{
    static class MAIN
    {
        static DispatcherTimer timer = new DispatcherTimer();

        public static void StartGame()
        {
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Tick += Animation;

            Global.InitializeAllSpaceObjects();

            Global.spaceShip.Draw();
            foreach (var x in Global.star_list)
            {
                x.Draw();
            }


            timer.Start();

        }

        /* 
        TODO: Refractor Code
        */
        private static void Animation(object sender, EventArgs e)
        {
            //ALLE SPACEOBJEKTE VON DER LEINDWAND ENTFERNEN
            Global.SpaceCanvas.Children.Clear();

            // DAS RAUMSCHIFF BEWEGEN UND DEM CANVAS HINZUFÜGEN

           
            
            Global.spaceShip.Move();
            Global.spaceShip.Show();
            
            // ALLE STERNE BEWEGEN UND DEM CANVAS HINZUFÜGEN
            foreach (var x in Global.star_list)
            {
                x.Move();
                x.Show();
            }
        }
    }
}
