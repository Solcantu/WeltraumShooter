using System.Windows;
using System.Windows.Media;


namespace WeltraumShooter2022_2023.CLASSES
{
    class SpaceShip : SpaceObject
    {
        public void Draw()
        {
            // Unser Shape braucht eine Form, Farbe, Größe
            Shape.Fill = Brushes.Yellow;

            Point Point0 = new Point(0, 0);
            Point Point1 = new Point(50, 10);
            Point Point2 = new Point(0, 20);
            Point Point3 = new Point(10, 10);

            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point0);
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            Shape.Points = myPointCollection;
        }

        
    }
}
