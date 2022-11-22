using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using Vector = System.Windows.Vector;
using System.Windows;
using System.Windows.Media;



namespace WeltraumShooter2022_2023.CLASSES
{
    abstract class SpaceObject
    {
        public Vector Pos = new Vector();
        public Polygon Shape = new Polygon();

        public KeyEventArgs LastPressedKey { get; set; }

        public virtual void Draw() // STERN
        {
            // Unser Shape braucht eine Form, Farbe, Größe
            double r = 1;
            Shape.Fill = Brushes.White;


            Point Point0 = new Point(r * 2, r * 0);
            Point Point1 = new Point(r * 4, r * 0);
            Point Point2 = new Point(r * 6, r * 2);
            Point Point3 = new Point(r * 6, r * 4);
            Point Point4 = new Point(r * 4, r * 6);
            Point Point5 = new Point(r * 2, r * 6);
            Point Point6 = new Point(r * 0, r * 4);



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

        public void Show()
        {
            // Unser Shape soll angezeigt werden auf dem Canvas
            Canvas.SetLeft(Shape, Pos.X);
            Canvas.SetTop(Shape, Pos.Y);

            Global.SpaceCanvas.Children.Add(Shape);
        }


    }
}
