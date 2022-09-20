using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace WeltraumShooter
{
    public class SpaceShip : SpaceObject
    {
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
    }
}