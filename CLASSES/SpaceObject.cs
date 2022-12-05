using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Windows.Input;
using System.Windows.Media;
using Vector = System.Windows.Vector;



namespace WeltraumShooter2022_2023.CLASSES
{
    abstract class SpaceObject
    {
        public Vector Pos = new Vector();
        public Polygon Shape = new Polygon();

        public KeyEventArgs LastPressedKey { get; set; }
        public bool isMoveable = false;

        public abstract void Draw();
     
        /// <summary>
        /// Zeichnet das entsprechende Objekt
        /// </summary>
        public void Show()
        {
            // Unser Shape soll angezeigt werden auf dem Canvas
            Canvas.SetLeft(Shape, Pos.X);
            Canvas.SetTop(Shape, Pos.Y);

            Global.SpaceCanvas.Children.Add(Shape);
        }

        /// <summary>
        /// Bewegt das entsprechende Objekt
        /// </summary>
        public void Move()
        {
            //Nur wenn es eine zuletzt gedrükte Taste gibt
            // null => Es ist KEIN Objekt vorhanden

            if (isMoveable && LastPressedKey != null)

                switch (LastPressedKey.Key)
                {
                    case Key.W:
                        this.Pos.Y -= 10;
                        break;
                    case Key.A:
                        this.Pos.X -= 10;
                        break;
                    case Key.S:
                        this.Pos.Y += 10;
                        break;
                    case Key.D:
                        this.Pos.X += 10;
                        break;
                    case Key.Space:
                        // Pew Pew
                        break;
                    default:
                        // code block
                        break;
                }
            if (this.Pos.Y < 0)
            {
                this.Pos.Y = 0;
            }
            if (this.Pos.Y > 380)
            {
                this.Pos.Y = 380;
            }

            if (this.Pos.X < 0)
            {
                this.Pos.X = 0;
            }
            if (this.Pos.X > Global.SpaceCanvas.ActualWidth - 50)
            {
                this.Pos.X = Global.SpaceCanvas.ActualWidth - 50;
            }

        }

        /// <summary>
        /// Wird ausgeführt wenn ein Objekt in dieses stößt
        /// </summary>
        public void OnCollisionEnter()
        {
            // Stuff dafür
        }
    }
}
