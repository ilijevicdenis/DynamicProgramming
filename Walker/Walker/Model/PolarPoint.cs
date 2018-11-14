using System;

namespace Walker.Model
{
    public sealed class PolarPoint
    {
        private readonly Point _cartessianPoint;
        public double Degree { get; private set; }
        public double R { get; private set; }

        public PolarPoint(Point p)
        {
            _cartessianPoint = p ?? throw new ArgumentNullException(nameof(p));
           R = ComputeR();
           Degree = ComputeAngle();
        }

        private double ComputeR() =>
                    Math.Sqrt(
                    Math.Pow(Convert.ToDouble(_cartessianPoint.X), 2) +
                    Math.Pow(Convert.ToDouble(_cartessianPoint.Y), 2));

        private double ComputeAngle() => RadianToDegree(Math.Atan(Convert.ToDouble(_cartessianPoint.X) / _cartessianPoint.Y));

        private double RadianToDegree(double angleInRadian) => angleInRadian * (180.0 / Math.PI);
    }
}
