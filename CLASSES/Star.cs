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
            // Unser Shape braucht eine Form, Farbe, Größe
            Shape.Fill = Brushes.White;

            Point Point0 = new Point(2, 0);
            Point Point1 = new Point(4, 0);
            Point Point2 = new Point(6, 2);
            Point Point3 = new Point(6, 4);
            Point Point4 = new Point(4, 6);
            Point Point5 = new Point(2, 6);
            Point Point6 = new Point(0, 4);

            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point0);
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPointCollection.Add(Point4);
            myPointCollection.Add(Point5);
            myPointCollection.Add(Point6);

            Shape.Points = myPointCollection;
        }

        public void Move()
        {
            
            Pos.X -= 5;

            if (Pos.X <= 0)
                Pos.X = Global.SpaceCanvas.ActualWidth;
        }
    }
}
