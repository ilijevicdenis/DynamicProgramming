using Walker.DataAccess;

namespace Walker.Model
{
    public class Axis : ViewModelBase
    {
        private readonly Tube _tube1;
        private readonly Tube _tube2;
        private readonly TubeFinder _finder;

        public Point Point1 { get; private set; }
        public Point Point2 { get; private set; }
        protected Axis(Tube p1, Tube p2, TubeFinder tubeFinder)
        {
            Point1 = new Point(p1);
            Point2 = new Point(p2);
            _finder = tubeFinder;

            _tube1 = p1;
            _tube2 = p2;
        }

        public Axis MoveLeft() => MoveForValue(-1);

        internal Axis MoveRight() => MoveForValue(1);

        private Axis MoveForValue(int colValue = 0, int rowValue = 0) =>
            new Axis(
                _finder.GetTubeByCoordinate(_tube1.Column + colValue, _tube1.Row + rowValue),
                _finder.GetTubeByCoordinate(_tube2.Column + colValue, _tube2.Row + rowValue),
                _finder);


        /// <summary>
        /// Tubes are perpedicular if the have same X value
        /// and they are horizontal if Y values are equal
        /// </summary>
        protected bool TubesArePerpedicualOrHorizontal
            => Point1.X == Point2.X || Point1.Y == Point2.Y;

        public Axis MoveUp() => MoveForValue(0, 1);

        public Axis MoveDown() =>  MoveForValue(0, -1);
    }
}
