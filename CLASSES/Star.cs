using System;
using System.Windows;
using System.Windows.Media;


namespace WeltraumShooter2022_2023.CLASSES
{
    class Star : SpaceObject
    {
        Random rnd = new Random();
        // Unser Konstruktor
        public Star()
        {
            Pos.X = rnd.Next(0, Convert.ToInt32(Global.SpaceCanvas.ActualWidth));
            Pos.Y = rnd.Next(0, Convert.ToInt32(Global.SpaceCanvas.ActualHeight));
        }


        public override void Draw() // STERN
        {
            
        }

        public void Move()
        {
            
            Pos.X -= 5;

            if (Pos.X <= 0)
                Pos.X = Global.SpaceCanvas.ActualWidth;
        }
    }
}
