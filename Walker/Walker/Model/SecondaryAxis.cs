using System;
using Walker.DataAccess;

namespace Walker.Model
{
    public sealed class SecondaryAxis : Axis
    {
        public SecondaryAxis(Tube p1, Tube p2, TubeFinder tubeFinder) : base(p1, p2, tubeFinder)
        {
            if (!TubesArePerpedicualOrHorizontal)
                throw new InvalidOperationException("Can't create secondary axis, given tubes aren't perpedicual or horizontal");
            NotifyOnPropertyChanged();
        }
    }
}
