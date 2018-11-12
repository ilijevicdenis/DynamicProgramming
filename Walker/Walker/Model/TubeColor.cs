using System;
using System.Drawing;
using Walker.GlobalData;

namespace Walker.Model
{
    public sealed class TubeColor
    {
        public TubeColor(string name, Color color)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Value = color;
        }
        public Color Value { get; private set; }
        public string Name { get; private set; }

        internal static TubeColor Resolve(Tube tube)
        {
            TubeColor resolved = null;

            switch (tube.Status.ToUpperInvariant())
            {
                case "UNKNOWN":
                    resolved = new TubeColor(Constants.GRAY_COLOR, Color.Gray);
                    break;
                case "PLUGGED":
                    resolved = new TubeColor(Constants.BLACK_COLOR, Color.Black);
                    break;
                case "CRITICAL":
                    resolved = new TubeColor(Constants.RED_COLOR, Color.Red);
                    break;
            }

            return resolved;
        }
    }
}
