using System;

namespace CW_1
{
    public class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        
        public Point(Point point)
        {
            this.X = point.X;
            this.Y = point.Y;
        }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Distance(Point point)
        {
            return Math.Round(Math.Sqrt((point.X - this.X) * (point.X - this.X) + (point.Y - this.Y) * (point.Y - this.Y)), 2);
        }

        public override string ToString()
        {
            return "(x:" + this.X.ToString() + ", y:" + this.Y.ToString() + ")";
        }
    }
}
