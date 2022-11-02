using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Input;

namespace WeltraumShooter
{
    public class SpaceShip : SpaceObject
    {
        private Vector _position = new Vector();
        Polygon polygon = new Polygon();
        public void positionchange (double x, double y)
        {

            this._position.X += x;
            this._position.Y += y;
        }
        public Vector getposition
        {
            get { return this._position; }
        } 
        public void Draw()
        {

            polygon.Fill = System.Windows.Media.Brushes.White;

            Point point1 = new Point(0, 10);
            Point point2 = new Point(10, 20);
            Point point3 = new Point(0, 30);
            Point point4 = new Point(30, 20);



            PointCollection pointcollection = new PointCollection();
            pointcollection.Add(point1);
            pointcollection.Add(point2);
            pointcollection.Add(point3);
            pointcollection.Add(point4);

            polygon.Points = pointcollection;

            Global.SpaceCanvas.Children.Add(polygon);



        }
        public void keyselect(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                     Global.direction = Direction.up;
                    break;

                case Key.S:
                    Global.direction = Direction.down;
                    break;

                case Key.A:
                    Global.direction = Direction.left;
                    break;

                case Key.D:
                    Global.direction = Direction.right;
                    break;
            }
            Move();
        }
        public void Move()
        {

            switch (Global.direction)
            {
                case Direction.up:
                    positionchange(0,-5);
                    break;

                case Direction.down:
                    positionchange(0,5);
                    break;

                case Direction.right:
                    positionchange(5,0);
                    break;

                case Direction.left:
                    positionchange(-5,0);
                    break;

            }
            Show();



        }
        public void Show()
        {
            Global.SpaceCanvas.Children.Remove(polygon);
            Canvas.SetLeft(polygon, getposition.X);
            Canvas.SetTop(polygon, getposition.Y);
            Global.SpaceCanvas.Children.Add(polygon);

        }
    }
}