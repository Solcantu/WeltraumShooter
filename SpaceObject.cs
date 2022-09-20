using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WeltraumShooter
{
    


    public class SpaceObject
    {

        

        public Vector position = new Vector ();
        Polygon polygon = new Polygon ();

        

        //private int textur;
        /*
        SpaceObject(Canvas canvas)
        {
            this._SpaceCanvas = canvas;
        }
        */
       

        public void Collision()
        {
            throw new System.NotImplementedException();
        }

        public void Draw()
        {

            polygon.Fill = System.Windows.Media.Brushes.White;
            
            Point point1 = new Point(50, 10);
            Point point2 = new Point(0, 20);
            Point point3 = new Point(10, 10);



            PointCollection pointcollection = new PointCollection();
            pointcollection.Add(point1);
            pointcollection.Add(point2);
            pointcollection.Add(point3);

            polygon.Points = pointcollection;

            Global.SpaceCanvas.Children.Add(polygon);



        }

        public void Move()
        {

            switch (Global.direction)
            {
                case Direction.up:
                    position.Y -= 5;
                    break;

                case Direction.down:
                    position.Y += 5;
                    break;

                case Direction.right:
                    position.X += 5;
                    break;

                case Direction.left:
                    position.X -= 5;
                    break;

            }
            Show();
                

            
        }

        public void Remove()
        {
            throw new System.NotImplementedException();
        }

        public void Show()
        {
            Global.SpaceCanvas.Children.Remove(polygon);
            Canvas.SetLeft(polygon, position.X);
            Canvas.SetTop(polygon, position.Y);
            Global.SpaceCanvas.Children.Add(polygon);

        }
    }
}