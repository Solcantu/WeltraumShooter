using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using Vector = System.Windows.Vector;



namespace WeltraumShooter2022_2023.CLASSES
{
    abstract class SpaceObject
    {
        public Vector Pos = new Vector();
        public Polygon Shape = new Polygon();

        public KeyEventArgs LastPressedKey { get; set; }

        public abstract void Draw();

        public void Show()
        {
            // Unser Shape soll angezeigt werden auf dem Canvas
            Canvas.SetLeft(Shape, Pos.X);
            Canvas.SetTop(Shape, Pos.Y);

            Global.SpaceCanvas.Children.Add(Shape);
        }


    }
}
