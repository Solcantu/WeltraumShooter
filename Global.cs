using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace WeltraumShooter
{
    public enum Direction
    {
        up,
        down,
        left,
        right,
    }
    public static class Global
    {

        public static Canvas SpaceCanvas { get; set; }
        public static  Direction direction { get; set; }

        public static List <Star> stars { get; set; }

    }
}