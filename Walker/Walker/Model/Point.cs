using System;
using Walker.GlobalData;

namespace Walker.Model
{
    public sealed class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public bool IsLocked { get; private set; }

        public Point(Tube tube)
        {
            X = tube.Column;
            Y = tube.Row;
            IsLocked = tube.TubeColor.Name == Constants.RED_COLOR;
        }

        private Point() { }

        public static Point FromPolarPoint(PolarPoint polarPoint)
        {

            var x = Convert.ToInt32(Math.Round(polarPoint.R * Math.Cos(polarPoint.Degree)));

            return new Point
            {
                X = x < 1 ? 1 : x,
                Y = Convert.ToInt32(polarPoint.R * Math.Sin(polarPoint.Degree))
            };
        }
    }
}
