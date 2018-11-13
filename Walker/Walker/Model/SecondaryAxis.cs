using System;
using Walker.DataAccess;

namespace Walker.Model
{
    public sealed class SecondaryAxis : ViewModelBase
    {
        private readonly Tube _tube1;
        private readonly Tube _tube2;
        private readonly TubeFinder _finder;

        public Point Point1 { get; private set; }
        public Point Point2 { get; private set; }
        public SecondaryAxis(Tube p1, Tube p2, TubeFinder tubeFinder)
        {
            Point1 = new Point(p1);
            Point2 = new Point(p2);
            _finder = tubeFinder;
            if (!TubesArePerpedicualOrHorizontal)
                throw new InvalidOperationException("Can't create secondary axis, given tubes aren't perpedicual or horizontal");

            _tube1 = p1;
            _tube2 = p2;

            NotifyOnPropertyChanged();
        }

        public SecondaryAxis MoveLeft() => MoveForValue(-1);

        internal SecondaryAxis MoveRight() => MoveForValue(1);

        private SecondaryAxis MoveForValue(int colValue) =>
            new SecondaryAxis(
                _finder.GetTubeByCoordinate(_tube1.Column + colValue, _tube1.Row),
                _finder.GetTubeByCoordinate(_tube2.Column + colValue, _tube2.Row),
                _finder);


        /// <summary>
        /// Tubes are perpedicular if the have same X value
        /// and they are horizontal if Y values are equal
        /// </summary>
        private bool TubesArePerpedicualOrHorizontal
            => Point1.X == Point2.X || Point1.Y == Point2.Y;
    }
}
