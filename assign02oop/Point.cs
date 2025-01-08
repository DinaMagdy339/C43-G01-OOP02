using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign02oop
{
    internal struct Point
    {
        #region Attributes 
        public int X { get; set; }
        public double Y { get; set; }
        #endregion

        #region Constructors
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        #endregion

        #region Method
        public static double Distance(Point p1, Point p2)
        {
            double d1 = p2.X - p1.X;
            double d2 = p2.Y - p1.Y;
            return Math.Sqrt(d1 * d1 + d2 * d2);
        }
        #endregion

    }
}

