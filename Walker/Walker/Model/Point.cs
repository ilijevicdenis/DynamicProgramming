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
    }
}
