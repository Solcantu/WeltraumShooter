using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;

namespace WeltraumShooter
{
    public class Star : SpaceObject
    {
        public Vector position = new Vector();
        Polygon star_polygon = new Polygon();

        Random rnd = new Random();

        public Star()
        {
            position.X = rnd.NextInt64(0, Convert.ToInt32(Global.SpaceCanvas.Width));
            position.Y = rnd.NextInt64(0, Convert.ToInt32(Global.SpaceCanvas.Height));
        }
        public void Draw()
        {

            star_polygon.Fill = System.Windows.Media.Brushes.Gray;

            Point point1 = new Point(10, 0);
            Point point2 = new Point(8, 5);
            Point point3 = new Point(0, 7);
            Point point4 = new Point(7, 8);
            Point point5 = new Point(5, 13);
            Point point6 = new Point(10, 10);
            Point point7 = new Point(15, 13);
            Point point8 = new Point(14, 8);
            Point point9 = new Point(20, 7);
            Point point10 = new Point(12, 5);



            PointCollection pointcollection = new PointCollection();
            pointcollection.Add(point1);
            pointcollection.Add(point2);
            pointcollection.Add(point3);
            pointcollection.Add(point4);
            pointcollection.Add(point5);
            pointcollection.Add(point6);
            pointcollection.Add(point7);
            pointcollection.Add(point8);
            pointcollection.Add(point9);
            pointcollection.Add(point10);


            star_polygon.Points = pointcollection;

            Global.SpaceCanvas.Children.Add(star_polygon);
            



        }
        public void Show()
        {
            Global.SpaceCanvas.Children.Remove(star_polygon);
            Canvas.SetLeft(star_polygon, position.X);
            Canvas.SetTop(star_polygon, position.Y);
            Global.SpaceCanvas.Children.Add(star_polygon);

        }

    }
}