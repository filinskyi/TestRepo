using System;

namespace Sprint01Library
{
    public class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        internal int[] GetXYPair() => new[] { x, y };

        protected internal double Distance(int x, int y)
            => Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));

        protected internal double Distance(Point point)
            => Math.Sqrt(Math.Pow(this.x - point.x, 2) + Math.Pow(this.y - point.y, 2));

        public static explicit operator double(Point point)
            => point.Distance(0, 0);
    }
}
